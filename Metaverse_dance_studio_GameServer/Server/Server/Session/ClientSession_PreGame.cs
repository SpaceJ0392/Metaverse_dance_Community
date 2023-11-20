using Google.Protobuf.Protocol;
using Server.Data;
using Server.Game;
using ServerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    public partial class ClientSession : PacketSession
    {
        public List<string> GuestId { get; private set; } = new List<string>();
        public List<LobbyPlayerInfo> LobbyPlayers { get; set; } = new List<LobbyPlayerInfo>();

        public void HandleLogin(C_Login loginPacket)
        {

            if (ServerState != PlayerServerState.ServerStateLogin)
                return;

            LobbyPlayers.Clear();

            //TODO : Disconnected 할 때 메모리 삭제 필수!!!		
            // UniqueId 메모리에 기억
            foreach (string target in GuestId)
            {
                if (target == loginPacket.UniqueId)
                    return;
            }
            GuestId.Add(loginPacket.UniqueId);

            //TEMP 선언
            LobbyPlayerInfo lobbyPlayer = new LobbyPlayerInfo()
            {
                PlayerId = Int32.Parse(loginPacket.UniqueId)
            };

            S_Login loginOk = new S_Login()
            {
                LoginOk = 1,
                PlayerInfo = lobbyPlayer
            };
            Send(loginOk);

            // 로비로 이동
            ServerState = PlayerServerState.ServerStateLobby;
        }

        public void HandleCreatePlayer(C_CreatePlayer createPacket)
        {
            // TODO : 이런 저런 보안 체크
            if (ServerState != PlayerServerState.ServerStateLobby)
                return;

            // 메모리에 추가
            LobbyPlayerInfo lobbyPlayer = new LobbyPlayerInfo() { PlayerId = createPacket.PlayerInfo.PlayerId };
            foreach (ItemInfo itemInfo in createPacket.PlayerInfo.Items)
            {
                Item item = Item.MakeItem(itemInfo);
                if (item != null)
                {
                    ItemInfo info = new ItemInfo();
                    info.MergeFrom(item.Info);
                    lobbyPlayer.Items.Add(info);
                }
            }

            // 메모리에 들고 있다(임시)
            LobbyPlayers.Add(lobbyPlayer);

            // 클라에 전송
            S_CreatePlayer newPlayer = new S_CreatePlayer() { PlayerInfo = new LobbyPlayerInfo() };
            newPlayer.PlayerInfo.MergeFrom(lobbyPlayer);

            Send(newPlayer);

        }
        public void HandleEnterGame(C_EnterGame enterGamePacket)
        {
            if (ServerState != PlayerServerState.ServerStateLobby)
                return;

            LobbyPlayerInfo playerInfo = LobbyPlayers.Find(p => p.PlayerId == enterGamePacket.PlayerInfo.PlayerId);
            if (playerInfo == null)
                return;

            //캐릭터 생성.
            MyPlayer = ObjectManager.Instance.Add<Player>(playerInfo.PlayerId);
            {
                MyPlayer.Info.PosInfo.State = CreatureState.Idle;
                MyPlayer.Info.PosInfo.MoveDir = MoveDir.Left;
                MyPlayer.Info.PosInfo.PosX = 0;
                MyPlayer.Info.PosInfo.PosY = -2;
                MyPlayer.Session = this;

                //TODO : 아이템 관련 정보 테이블을 만들어서 정보 추출.
                //클라에서 추출해서 createpacket에 담아 보내주어야 함.
                foreach (ItemInfo itemInfo in playerInfo.Items)
                {
                    Item item = Item.MakeItem(itemInfo);
                    if (item != null)
                    {
                        MyPlayer.Inven.Add(item);
                    }

                }
            }

            ServerState = PlayerServerState.ServerStateGame;

            GameLogic.Instance.Push(() =>
            {
                GameRoom room = GameLogic.Instance.Find(1);
                room.Push(room.EnterGame, MyPlayer);
            });
        }
    }
}


