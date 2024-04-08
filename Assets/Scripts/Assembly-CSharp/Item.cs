using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020001EA RID: 490
[CreateAssetMenu(fileName = "Item", menuName = "W/Item", order = -1)]
public class Item : ScriptableObject
{
	public float ToolRarity { get; }
	public Guid PersistentID { get; set; }

	// Token: 0x04000771 RID: 1905
	[FormerlySerializedAs("shopName")]
	public string displayName;

	// Token: 0x04000772 RID: 1906
	public Sprite icon;

	// Token: 0x04000773 RID: 1907
	public GameObject itemObject;

	// Token: 0x04000774 RID: 1908
	public Item.ItemType itemType = Item.ItemType.Tool;

	// Token: 0x04000775 RID: 1909
	[FormerlySerializedAs("toolBudget")]
	public int toolBudgetCost = 1;

	// Token: 0x04000776 RID: 1910
	public bool spawnable;

	// Token: 0x04000777 RID: 1911
	public Item.RARITY toolSpawnRarity = Item.RARITY.common;

	// Token: 0x04000778 RID: 1912
	public int budgetCost;

	// Token: 0x04000779 RID: 1913
	public float rarity = 1f;

	// Token: 0x0400077A RID: 1914
	public PropContent content;

	// Token: 0x0400077B RID: 1915
	public float groundSizeMultiplier = 1f;

	// Token: 0x0400077C RID: 1916
	public float groundMassMultiplier = 1f;

	// Token: 0x0400077D RID: 1917
	public float mass = 3f;

	// Token: 0x0400077E RID: 1918
	public Vector3 holdPos;

	// Token: 0x0400077F RID: 1919
	public bool useAlternativeHoldingPos;

	// Token: 0x04000780 RID: 1920
	public Vector3 alternativeHoldPos;

	// Token: 0x04000781 RID: 1921
	public Vector3 holdRotation;

	// Token: 0x04000782 RID: 1922
	public bool useAlternativeHoldingRot;

	// Token: 0x04000783 RID: 1923
	public Vector3 alternativeHoldRot;

	// Token: 0x04000784 RID: 1924
	public byte id;

	// Token: 0x04000785 RID: 1925
	public string persistentID;

	// Token: 0x04000786 RID: 1926
	public bool purchasable;

	// Token: 0x04000787 RID: 1927
	public ShopItemCategory Category;

	// Token: 0x04000788 RID: 1928
	public int price;

	// Token: 0x04000789 RID: 1929
	public int quantity;

	// Token: 0x0400078A RID: 1930
	public Emote emoteInfo;

	// Token: 0x0400078B RID: 1931
	public List<ItemKeyTooltip> Tooltips = new List<ItemKeyTooltip>();

	// Token: 0x0200037B RID: 891
	public enum ItemType
	{
		// Token: 0x04000FE8 RID: 4072
		Camera,
		// Token: 0x04000FE9 RID: 4073
		Tool,
		// Token: 0x04000FEA RID: 4074
		Artifact,
		// Token: 0x04000FEB RID: 4075
		Disc
	}

	// Token: 0x0200037C RID: 892
	public enum RARITY
	{
		// Token: 0x04000FED RID: 4077
		always = 10,
		// Token: 0x04000FEE RID: 4078
		superCommon = 50,
		// Token: 0x04000FEF RID: 4079
		moreCommon = 75,
		// Token: 0x04000FF0 RID: 4080
		common = 100,
		// Token: 0x04000FF1 RID: 4081
		lessCommon = 150,
		// Token: 0x04000FF2 RID: 4082
		uncommon = 1000,
		// Token: 0x04000FF3 RID: 4083
		rare = 10000,
		// Token: 0x04000FF4 RID: 4084
		epic = 100000,
		// Token: 0x04000FF5 RID: 4085
		legendary = 1000000,
		// Token: 0x04000FF6 RID: 4086
		mythic = 10000000
	}
}
