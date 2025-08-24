using UnityEngine;

public class InfoCtrl : MonoBehaviour
{
    [SerializeField] private ImageUI _img;
    [SerializeField] private TextUI _txt;

    public void SetImg(Sprite sprite)
    {
        _img.SetImage(sprite);
    }

    public void SetTxt(string input)
    {
        _txt.SetText(input);
    }
}
