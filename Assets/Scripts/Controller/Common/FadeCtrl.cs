using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class FadeCtrl : MonoBehaviour
{
    [SerializeField] private FadeUI _fadeView;
    [SerializeField] private FadeModel _fadeModel;

    public void PlayFadeSequence()
    {
        StopAllCoroutines();
        _fadeView.SetAlpha(0f);
        StartCoroutine(nameof(CoFadeSequence));
    }

    public IEnumerator CoFadeSequence()
    {
        yield return CoFade(0, 1, _fadeModel.FadeDuration);
        yield return new WaitForSeconds(_fadeModel.DisplayTime);
        yield return CoFade(1, 0, _fadeModel.FadeDuration);
    }

    private IEnumerator CoFade(float from, float to, float duration)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / duration);
            float alpha = Mathf.Lerp(from, to, t);
            _fadeView.SetAlpha(alpha);
            yield return null;
        }
    }
}
