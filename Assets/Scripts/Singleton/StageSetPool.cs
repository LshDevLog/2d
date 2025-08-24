using UnityEngine;

public class StageSetPool : MonoBehaviour
{
    public static StageSetPool Instance { get; private set; }

    [SerializeField] private StageSetCtrl _stageSetPrefab;
    private ObjectPool<StageSetCtrl> _stageSetPool;

    [SerializeField] private StageConfig _stageConfig;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Init();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Init()
    {
        _stageSetPool = new ObjectPool<StageSetCtrl>(_stageSetPrefab, _stageConfig.StageModelArr.Length, transform, maxCount: 50);
    }

    public StageSetCtrl Get(Transform parent)
    {
        StageSetCtrl stage = _stageSetPool.GetObj();
        stage.transform.SetParent(parent, false);
        return stage;
    }

    public void Return(StageSetCtrl stage)
    {
        _stageSetPool.ReturnObj(stage);
        stage.transform.SetParent(transform, false);
    }

    public void ReturnAllStageSets()
    {
        _stageSetPool.ReturnAll();
    }
}
