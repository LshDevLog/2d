using UnityEngine;

public class InvenSlotCtrl : MonoBehaviour
{
    [SerializeField] private StatModel _statModel;
    [SerializeField] private ImageUI _icon;
    [SerializeField] private TextUI _lvTxt;
    [SerializeField] private TextUI _descTxt;


    public void Init(int level)
    {
        _icon.SetImage(_statModel._iconSprite);
        SetTexts(level);
    }

    public void SetTexts(int level)
    {
        _lvTxt.SetText("Lv: " + level.ToString("F0"));
        float result = level * _statModel._statPerLevel;
        string floating = _statModel.IsStatFloatValue ? "F1" : "F0";
        _descTxt.SetText($"{_statModel._statName}: {result.ToString(floating)}");
    }
}
