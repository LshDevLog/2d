using UnityEngine;

[CreateAssetMenu(menuName = "Game/ShopSlotModel")]
public class ShopSlotModel : ScriptableObject
{
    [field: SerializeField] public Sprite Slot_Img { get; private set; }
    [field: SerializeField] public eShopSlotType SlotType { get; private set; }
    [field: SerializeField] public int NeededGold { get; private set; }
    [field: SerializeField] public int Amount { get; private set; }
}

public enum eShopSlotType
{
    Gem,
    Torch
}
