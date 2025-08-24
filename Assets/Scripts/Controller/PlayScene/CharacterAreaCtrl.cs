using UnityEngine;

public class CharacterAreaCtrl : MonoBehaviour
{
    [SerializeField] private SimpleImgModel _attackIconModel;
    [SerializeField] private SimpleImgModel _defenceIconModel;
    [SerializeField] private SimpleImgModel _speedIconModel;
    [SerializeField] private ImageUI _characterImgUI;
    [SerializeField] private ImageUI _attackIconImgUI;
    [SerializeField] private ImageUI _defenceIconImgUI;
    [SerializeField] private ImageUI _speedIconImgUI;
    [SerializeField] private ImageUI _attackFadeIconImgUI;
    [SerializeField] private ImageUI _defenceFadeIconImgUI;
    [SerializeField] private ProgressCtrl _hpProgressCtrl;
    [SerializeField] private ProgressCtrl _coolTimeProgressCtrl;
    [SerializeField] private FadeCtrl _attackFadeCtrl;
    [SerializeField] private FadeCtrl _shieldSuccessFadeCtrl;
    [SerializeField] private InfoCtrl _attackInfo;
    [SerializeField] private InfoCtrl _defenceInfo;
    [SerializeField] private InfoCtrl _speedInfo;

    public void InitCharacterArea(Sprite characterSprtie, int attack, float defence, float speed, int maxHP)
    {
        _attackIconImgUI.SetImage(_attackIconModel._iconSprite);
        _defenceIconImgUI.SetImage(_defenceIconModel._iconSprite);
        _speedIconImgUI.SetImage(_speedIconModel._iconSprite);
        _attackFadeIconImgUI.SetImage(_attackIconModel._iconSprite);
        _defenceFadeIconImgUI.SetImage(_defenceIconModel._iconSprite);
        _characterImgUI.SetImage(characterSprtie);
        _attackInfo.SetTxt(attack.ToString());
        _defenceInfo.SetTxt(defence.ToString("F2"));
        _speedInfo.SetTxt(speed.ToString("F2"));
        UpdateHpBar(maxHP, maxHP);
        UpdateCoolTimeProgress(0f, 1f);
    }

    public void UpdateHpBar(int curValue, int maxValue)
    {
        _hpProgressCtrl.UpdateGauge(curValue, maxValue);
    }

    public void UpdateCoolTimeProgress(float curValue, float maxValue)
    {
        _coolTimeProgressCtrl.UpdateGauge(curValue, maxValue);
    }

    public void AttackFade()
    {
        _attackFadeCtrl.PlayFadeSequence();
    }

    public void ShieldSuccess()
    {
        _shieldSuccessFadeCtrl.PlayFadeSequence();
    }

    public void ClearCharacterArea()
    {
        _characterImgUI.gameObject.SetActive(false);
        _coolTimeProgressCtrl.gameObject.SetActive(false);
        _attackInfo.SetTxt(0.ToString());
        _defenceInfo.SetTxt(0.ToString());
        _speedInfo.SetTxt(0.ToString());
        UpdateHpBar(0, 1);
    }
}
