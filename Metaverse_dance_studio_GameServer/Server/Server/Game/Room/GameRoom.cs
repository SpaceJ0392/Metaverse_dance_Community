using Google.Protobuf;
using Google.Protobuf.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Game
{
    public partial class GameRoom : JobSerializer
    {
        object _lock = new object();
        public int RoomId { get; set; }

        Dictionary<int, Player> _players = new Dictionary<int, Player>();

        public Map Map { get; private set; } = new Map();

        public void Init(int mapId)
        {
            Map.LoadMap(mapId);
        }

        // 누군가 주기적으로 호출해줘야 한다
        public void Update()
        {
            Flush();
        }

        public void EnterGame(GameObject gameObject)
        {
            if (gameObject == null)
                return;

            GameObjectType type = ObjectManager.GetObjectTypeByObj(gameObject);

            if (type == GameObjectType.Player)
            {
                Player player = gameObject as Player;
                _players.Add(gameObject.Id, player);
                player.Room = this;

                Map.ApplyMove(player, new Vector2Int(player.CellPos.x, player.CellPos.y));

                // 본인한테 정보 전송
                {
                    S_EnterGame enterPacket = new S_EnterGame();
                    enterPacket.PlayerInfo = player.Info;
                    foreach (Item item in player.Inven.Items.Values)
                    {
                        ItemInfo itemInfo = new ItemInfo()
                        {
                            TemplateId = item.TemplateId,
                            ItemName = item.ItemName,
                            Type = item.ItemType
                        };

                        enterPacket.PlayerInfo.Items.Add(itemInfo);
                    }

                    player.Session.Send(enterPacket);

                    S_Spawn spawnPacket = new S_Spawn();
                    foreach (Player p in _players.Values)
                    {
                        if (player != p)
                            spawnPacket.Objects.Add(p.Info);
                    }

                    player.Session.Send(spawnPacket);
                }

                { 
                    //상대한테 정보 전송
                    S_Spawn spawnPacket = new S_Spawn();
                    spawnPacket.Objects.Add(gameObject.Info);
                    foreach (Player p in ObjectManager.Instance.Players.Values)
                    {
                        if (player != p)
                            p.Session.Send(spawnPacket);
                    }

                }
            }

        }

        public void LeaveGame(GameObject obj)
        {

            Player player = null;
            if (_players.Remove(obj.Id, out player) == false)
                return;

            Map.ApplyLeave(player);
            player.Room = null;
            Player MyPlayer = null;
            ObjectManager.Instance.Players.Remove(player.Id, out MyPlayer);

            // 본인한테 정보 전송
            {
                S_LeaveGame leavePacket = new S_LeaveGame();
                player.Session.Send(leavePacket);
            }


            // 타인한테 정보 전송
            {
                S_Despawn despawnPacket = new S_Despawn();
                despawnPacket.ObjectIds.Add(obj.Id);
                foreach (Player p in ObjectManager.Instance.Players.Values)
                {
                    if (p.Id != obj.Id)
                        p.Session.Send(despawnPacket);
                }
            }
        }
        public Player FindPlayer(Func<GameObject, bool> condition)
        {
            foreach (Player player in ObjectManager.Instance.Players.Values)
            {
                if (condition.Invoke(player))
                    return player;
            }

            return null;
        }

        public void Broadcast(IMessage packet)
        {
            foreach (Player p in ObjectManager.Instance.Players.Values)
            {
                p.Session.Send(packet);
            }

        }
    }
}
