using Google.Protobuf.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data
{
	#region Item
	[Serializable]
	public class ItemData
	{
		public int TemplateId;
		public string name;
		public ItemType itemType;
	}

	[Serializable]
	public class ItemLoader : ILoader<int, ItemData>
	{
		public List<ItemData> items = new List<ItemData>();
		public Dictionary<int, ItemData> MakeDict()
		{
			Dictionary<int, ItemData> dict = new Dictionary<int, ItemData>();
			foreach (ItemData item in items)
			{
				dict.Add(item.TemplateId, item);
			}
			return dict;
		}
	}
	#endregion
}
