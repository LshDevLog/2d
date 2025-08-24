using UnityEngine;

[CreateAssetMenu(menuName = "Game/StageConfig")]
public class StageConfig : ScriptableObject
{
    [field: SerializeField] public int StageNumber { get; private set; } = 2;
    [field: SerializeField] public StageModel[] StageModelArr { get; private set; }
}
