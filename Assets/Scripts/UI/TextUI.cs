using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    [SerializeField] private Text _txt;

    public void SetText(string text)
    {
        _txt.text = text;
    }
}
