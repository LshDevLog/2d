using UnityEngine;

public class ArrowSetCtrl : MonoBehaviour
{
    [SerializeField] private BtnUI _leftArrowBtn;
    [SerializeField] private BtnUI _rightArrowBtn;

    [SerializeField] private StageSetCtrl[] _stageSetCtrlArr;
    [SerializeField] private int _curStageIdx = 0;
    public void InitArrowBtns(StageSetCtrl[] stageSetCtrlArr)
    {
        _stageSetCtrlArr = new StageSetCtrl[stageSetCtrlArr.Length];
        for (int i = 0; i < _stageSetCtrlArr.Length; ++i)
        {
            _stageSetCtrlArr[i] = stageSetCtrlArr[i];
        }
        _leftArrowBtn.Add(OnClickLeftArrow);
        _rightArrowBtn.Add(OnClickRightArrow);

        ShowCurStage(_curStageIdx);
    }


    private void OnClickLeftArrow()
    {
        _curStageIdx = (_curStageIdx <= 0) ? _stageSetCtrlArr.Length - 1 : --_curStageIdx;
        ShowCurStage(_curStageIdx);
    }

    private void OnClickRightArrow()
    {
        _curStageIdx = (_curStageIdx >= _stageSetCtrlArr.Length - 1) ? 0 : ++_curStageIdx;
        ShowCurStage(_curStageIdx);
    }

    private void ShowCurStage(int curStageIdx)
    {
        for (int i = 0; i < _stageSetCtrlArr.Length; ++i)
        {
            bool isActive = (i == curStageIdx);
            _stageSetCtrlArr[i].gameObject.SetActive(isActive);
        }
    }
}
