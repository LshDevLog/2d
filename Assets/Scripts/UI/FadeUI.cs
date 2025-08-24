using UnityEngine;

public class FadeUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup _splashCanvasGroup;

    public void SetAlpha(float alpha)
    {
        _splashCanvasGroup.alpha = alpha;
    }
}
