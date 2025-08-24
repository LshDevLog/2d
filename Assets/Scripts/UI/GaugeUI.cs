using UnityEngine;
using UnityEngine.UI;

public class GaugeUI : MonoBehaviour
{
    [SerializeField] private Image _progressBarImg;

    public void SetProgressValue(float value)
    {
        _progressBarImg.fillAmount = value;
    }
}
