using UnityEngine;

public class GameTempDataContainer : MonoBehaviour
{
    public static GameTempDataContainer Instance {  get; private set; }

    [SerializeField]
    private StageModel _curStageModel = null;

    public bool IsFirstGameExecution = true;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

   public void SetCurStageModel(StageModel curSelectedStageModel)
   {
        _curStageModel = curSelectedStageModel;
   }

    public StageModel GetCurStageModel()
    {
        return _curStageModel;
    }
}
