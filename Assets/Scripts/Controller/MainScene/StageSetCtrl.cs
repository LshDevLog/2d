using UnityEngine;

public class StageSetCtrl : MonoBehaviour
{
    [SerializeField] private StageModel _stageModel;
    [SerializeField] private TextUI _textUI;
    [SerializeField] private BtnUI _btnUI;
    [SerializeField] private ImageUI _imgUI;
    [SerializeField] private ImageUI[] _neededTorchImgUIArr;
    public void InitStageSet(StageModel stageModel)
    {
        _stageModel = stageModel;
        string stage = $"-Stage {_stageModel.StageOrderNumber}-\n";
        _textUI.SetText(stage + _stageModel.StageName);
        _imgUI.SetImage(_stageModel.StageMainEnemySprite);

        if (_stageModel.NeededTorch > 0)
        {
            for (int i = 0; i < _stageModel.NeededTorch; ++i)
            {
                _neededTorchImgUIArr[i].gameObject.SetActive(true);
            }
        }

        _btnUI.Add(() => MainSceneStageManager.Instance.TryPlay(_stageModel));
    }
}
