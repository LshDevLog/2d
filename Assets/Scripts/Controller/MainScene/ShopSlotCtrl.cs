using UnityEngine;

public class ShopSlotCtrl : MonoBehaviour
{
    [SerializeField] private ShopSlotModel _shopSlotModel;
    [SerializeField] private SimpleImgModel _goldModel;
    [SerializeField] private ImageUI _imgUI;
    [SerializeField] private TextUI _amountTxt;
    [SerializeField] private BtnUI _btnUI;
    [SerializeField] private InfoCtrl _infoCtrl;

    public void InitSlot()
    {
        _imgUI.SetImage(_shopSlotModel.Slot_Img);
        _amountTxt.SetText("x" + _shopSlotModel.Amount.ToString());
        _infoCtrl.SetTxt(_shopSlotModel.NeededGold.ToString());
        _infoCtrl.SetImg(_goldModel._iconSprite);
        _btnUI.Add(Buy);
    }

    public void Buy()
    {
        if (PlayerDataCtrl.Instance.GetGold() < _shopSlotModel.NeededGold)
            return;

        PlayerDataCtrl.Instance.ChangeGoods(eGoodsType.Gold, -_shopSlotModel.NeededGold);
        switch (_shopSlotModel.SlotType)
        {
            case eShopSlotType.Gem:
                PlayerDataCtrl.Instance.ChangeGoods(eGoodsType.Gem, _shopSlotModel.Amount);
                break;
            case eShopSlotType.Torch:
                PlayerDataCtrl.Instance.ChangeGoods(eGoodsType.Torch, _shopSlotModel.Amount);
                break;
        }
    }
}
