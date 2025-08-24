using UnityEngine;
using UnityEngine.Events;

public class PotionCtrl : MonoBehaviour
{
    [SerializeField] private SimpleImgModel _potionIconModel;
    [SerializeField] private ImageUI _potionUI;
    [SerializeField] private TextUI _remainingPotionTxt;
    [SerializeField] private BtnUI _useBtn;

    public void InitPotionBtn(UnityAction action)
    {
        _potionUI.SetImage(_potionIconModel._iconSprite);
        _useBtn.Add(action);
    }

    public void SetRemainingPotionText(int remainingPotionNum)
    {
        int maxValue = PlayerDataCtrl.Instance.GetPoitonNum();
        string result = $"{remainingPotionNum}/{maxValue}";
        _remainingPotionTxt.SetText(result);
    }

    public void DisableButton()
    {
        _useBtn.DisableBtn();
    }
}
