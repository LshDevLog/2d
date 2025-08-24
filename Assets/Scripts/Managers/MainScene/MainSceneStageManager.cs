using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneStageManager : MonoBehaviour
{
    public static MainSceneStageManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void TryPlay(StageModel stageModel)
    {
        bool isAvailable = PlayerDataCtrl.Instance.GetTorch() >= stageModel.NeededTorch;
        if (isAvailable)
        {
            StageSetPool.Instance.ReturnAllStageSets();
            PlayerDataCtrl.Instance.ChangeGoods(eGoodsType.Torch, -stageModel.NeededTorch);
            GameTempDataContainer.Instance.SetCurStageModel(stageModel);
            SceneManager.LoadScene("Play");
        }
        else
        {
            Debug.Log("횃불이 부족합니다.");
        }
    }
}
