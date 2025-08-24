using UnityEngine;
using UnityEngine.UI;

public class ImageUI : MonoBehaviour
{
    [SerializeField] private Image _img;

    public void SetImage(Sprite sprite)
    {
        _img.sprite = sprite;
    }
}
