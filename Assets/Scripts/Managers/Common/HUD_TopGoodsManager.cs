using UnityEngine;

public class HUD_TopGoodsManager : MonoBehaviour
{
    public static HUD_TopGoodsManager Instance {  get; private set; }

    [SerializeField] private TopGoodsCtrl _topGoodsCtrl;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _topGoodsCtrl.InitInfoImg();
        _topGoodsCtrl.UpdateGoldInfoTxt();
        _topGoodsCtrl.UpdateGemInfoTxt();
        _topGoodsCtrl.UpdateTorchInfoTxt();
    }

    public void UpdateInfoTxt()
    {
        _topGoodsCtrl.UpdateGoldInfoTxt();
        _topGoodsCtrl.UpdateGemInfoTxt();
        _topGoodsCtrl.UpdateTorchInfoTxt();
    }
}