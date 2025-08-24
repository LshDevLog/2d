using UnityEngine;

public class TextCtrlManager : MonoBehaviour
{
    [SerializeField] private TextCtrl[] _TxtCtrlArr;

    private void Start()
    {
        InitText();
    }

    private void InitText()
    {
        for (int i = 0; i < _TxtCtrlArr.Length; ++i)
        {
            _TxtCtrlArr[i].ShowTxt();
        }
    }
}
