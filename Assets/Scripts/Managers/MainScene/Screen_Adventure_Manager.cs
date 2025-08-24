using System.Collections;
using UnityEngine;

public class Screen_Adventure_Manager : MonoBehaviour
{
    [Header("StageSet"), SerializeField] private StageConfig _stageConfig;
    private StageSetCtrl[] _stageCtrls;

    [Header("Arrow"),SerializeField] private ArrowSetCtrl _arrowSetCtrl;

    private void Awake()
    {
        _stageCtrls = new StageSetCtrl[_stageConfig.StageModelArr.Length];
    }

    public void InitAdventureScreen()
    {
        InitStageSets();
        InitArrowSets();
    }

    private void InitStageSets()
    {
        for (int i = 0; i < _stageCtrls.Length; ++i)
        {
            var stageSet = StageSetPool.Instance.Get(transform);
            _stageCtrls[i] = stageSet;
            _stageCtrls[i].transform.position = transform.position;
            _stageCtrls[i].InitStageSet(_stageConfig.StageModelArr[i]);
        }
        _stageCtrls[0].gameObject.SetActive(true);
    }

    private void InitArrowSets()
    {
        _arrowSetCtrl.InitArrowBtns(_stageCtrls);
    }
}
