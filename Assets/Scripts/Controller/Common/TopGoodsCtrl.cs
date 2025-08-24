using UnityEngine;

public class TopGoodsCtrl : MonoBehaviour
{
    [SerializeField] private SimpleImgModel _goldModel;
    [SerializeField] private SimpleImgModel _upgradeModel;
    [SerializeField] private SimpleImgModel _torchModel;
    [SerializeField] private InfoCtrl _goldInfo;
    [SerializeField] private InfoCtrl _upgradeInfo;
    [SerializeField] private InfoCtrl _torchInfo;

    public void InitInfoImg()
    {
        _goldInfo.SetImg(_goldModel._iconSprite);
        _upgradeInfo.SetImg(_upgradeModel._iconSprite);
        _torchInfo.SetImg(_torchModel._iconSprite);
    }

    public void UpdateGoldInfoTxt()
    {
        string gold = PlayerDataCtrl.Instance.GetGold().ToString();
        _goldInfo.SetTxt(gold);
    }

    public void UpdateGemInfoTxt()
    {
        string gem = PlayerDataCtrl.Instance.GetGem().ToString();
        _upgradeInfo.SetTxt(gem);
    }

    public void UpdateTorchInfoTxt()
    {
        string torch = PlayerDataCtrl.Instance.GetTorch().ToString();
        _torchInfo.SetTxt(torch);
    }
}
