using System.Collections.Generic;
using UnityEngine;
using Zorro.Core;

// Token: 0x020000D1 RID: 209
[CreateAssetMenu(menuName = "Database/ItemDatabase", order = 9999, fileName = "ItemDatabase")]
public class ItemDatabase : ObjectDatabaseAsset<ItemDatabase, Item>
{
	// Token: 0x04000286 RID: 646
	public List<string> lastLoadedPersistentIDs = new List<string>();

	// Token: 0x04000287 RID: 647
	public List<Item> lastLoadedItems = new List<Item>();
}
