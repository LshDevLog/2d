using System.Collections;
using System.Text;
using UnityEngine;

public class TextCtrl : MonoBehaviour
{
    [SerializeField] private TextUI _txtUI;
    [SerializeField] private TextModel _txtModel;

    public void PlayTextSequence()
    {
        StartCoroutine(nameof(CoTextSequence));
    }

    public IEnumerator CoTextSequence()
    {
        _txtUI.SetText(string.Empty);
        StringBuilder sb = new StringBuilder();
        char[] c = _txtModel.InputString.ToCharArray();
        for (int idx = 0; idx < c.Length; idx++)
        {
            sb.Append(c[idx]);
            _txtUI.SetText(sb.ToString());
            yield return new WaitForSeconds(_txtModel.DelayTime);
        }
    }

    public void ShowTxt()
    {
        _txtUI.SetText(_txtModel.InputString);
    }
}
