using UnityEngine;

public class RewardCtrl : MonoBehaviour
{
    [SerializeField] private SimpleImgModel _goldImgModel;
    [SerializeField] private SimpleImgModel _gemImgModel;
    [SerializeField] private SimpleImgModel _torchImgModel;
    [SerializeField] private TextModel _closeTxtModel;
    [SerializeField] private TextUI _closeBtnTxt;
    [SerializeField] private InfoCtrl[] _infoCtrls;

    public void GiveReward()
    {
        InitUI();

        RewardModel model = GameTempDataContainer.Instance.GetCurStageModel().RewardModel;

        SetReward(_infoCtrls[0], eGoodsType.Gold, 100, model.GoldAmount.Min, model.GoldAmount.Max);
        SetReward(_infoCtrls[1], eGoodsType.Gem, model.GemProbability, model.GemAmount.Min, model.GemAmount.Max);
        SetReward(_infoCtrls[2], eGoodsType.Torch, model.TorchProbability, model.TorchAmount.Min, model.TorchAmount.Max);
    }

    public void DontGiveReward()
    {
        InitUI();

        for (int i = 0; i < _infoCtrls.Length; ++i)
        {
            _infoCtrls[i].SetTxt("x0");
        }
    }

    private void SetReward(InfoCtrl infoCtrl,eGoodsType goodsType, float possibility, int rewardMin, int rewardMax)
    {
        float ran = Random.Range(0, 100);
        if(ran <= possibility)
        {
            int getReward = Random.Range(rewardMin, rewardMax + 1);
            infoCtrl.SetTxt($"x{getReward}");
            PlayerDataCtrl.Instance.ChangeGoods(goodsType, getReward);
        }
        else
        {
            infoCtrl.SetTxt("x0");
        }
    }

    private void InitUI()
    {
        _infoCtrls[0].SetImg(_goldImgModel._iconSprite);
        _infoCtrls[1].SetImg(_gemImgModel._iconSprite);
        _infoCtrls[2].SetImg(_torchImgModel._iconSprite);
        _closeBtnTxt.SetText(_closeTxtModel.InputString);
    }
}
