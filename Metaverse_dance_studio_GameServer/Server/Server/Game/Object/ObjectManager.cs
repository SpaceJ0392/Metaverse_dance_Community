using Google.Protobuf.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Game
{
	public class ObjectManager
	{
		public static ObjectManager Instance { get; } = new ObjectManager();

		object _lock = new object();

		public Dictionary<int, Player> Players { get; set; } = new Dictionary<int, Player>();
		
		

		// [UNUSED(1)][TYPE(7)][ID(24)]

		public T Add<T>(int objectId) where T : GameObject, new()
		{
			T gameObject = new T();

			lock (_lock)
			{
				gameObject.Id = objectId;

				if (gameObject.ObjectType == GameObjectType.Player)
				{
					Players.Add(gameObject.Id, gameObject as Player);
				}
			}

			return gameObject;
		}

		public static GameObjectType GetObjectTypeByObj(GameObject gameObject)
		{

			return gameObject.ObjectType;
		}

			public bool Remove(GameObject obj)
		{
			GameObjectType objectType = GetObjectTypeByObj(obj);

			lock (_lock)
			{
				if (objectType == GameObjectType.Player)
                {
					return Players.Remove(obj.Id);
				}
					
			}

			return false;
		}

		public Player Find(GameObject obj)
		{
			GameObjectType objectType = GetObjectTypeByObj(obj);

			lock (_lock)
			{
				if (objectType == GameObjectType.Player)
				{
					Player player = null;
					if (Players.TryGetValue(obj.Id, out player))
						return player;
				}
			}

			return null;
		}
	}
}
