using Google.Protobuf.Protocol;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Game
{
    public class Item
    {
		public ItemInfo Info { get; } = new ItemInfo();

		public int TemplateId
		{
			get { return Info.TemplateId; }
			set { Info.TemplateId = value; }
		}
		public string ItemName
        {
            get { return Info.ItemName; }
            set { Info.ItemName = value; }
        }
		public int Slot
		{
			get { return Info.Slot; }
			set { Info.Slot = value; }
		}

		public ItemType ItemType { get; private set; }
		public bool Stackable { get; protected set; }

		public Item()
		{

		}
		public Item(ItemType itemType)
		{
			ItemType = itemType;
		}

		public static Item MakeItem(ItemInfo itemInfo)
		{
			

			ItemData itemData = null;
			DataManager.ItemDict.TryGetValue(itemInfo.TemplateId, out itemData);

			if (itemData == null)
				return null;

			Item item = new Item();
			item.TemplateId = itemInfo.TemplateId;
			item.ItemName = itemInfo.ItemName;
			item.ItemType = itemInfo.Type;
			item.Stackable = false;

			return item;
		}
	}
}
