using UnityEngine;

public class ProgressCtrl : MonoBehaviour
{
    [SerializeField] private GaugeUI _gauge;
    [SerializeField] private TextUI _txt;

    public void UpdateGauge(float curValue, float maxValue)
    {
        float gaugeValue = Mathf.Clamp01(curValue / maxValue);
        _gauge.SetProgressValue(gaugeValue);
        if (_txt == null)
            return;
        string txt = $"{curValue}/{maxValue}";
        _txt.SetText(txt);
    }

    public void UpdateGauge(int curValue, int maxValue)
    {
        float gaugeValue = Mathf.Clamp01((float)curValue / maxValue);
        _gauge.SetProgressValue(gaugeValue);
        if (_txt == null)
            return;
        string txt = $"{curValue}/{maxValue}";
        _txt.SetText(txt);
    }
}
