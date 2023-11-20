using Google.Protobuf.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Game
{
	public class Player : GameObject
	{
		public int PlayerId { get; set; }
		public ClientSession Session { get; set; }
		public Inventory Inven { get; private set; } = new Inventory();

		public Player()
		{
			ObjectType = GameObjectType.Player;
		}
		
	}
}
