using UnityEngine;

[CreateAssetMenu(menuName = "Game/StageModel")]
public class StageModel : ScriptableObject
{
    [field: SerializeField] public string StageName { get; private set; } = string.Empty;
    [field: SerializeField] public int StageOrderNumber { get; private set; } = 0;
    [field: SerializeField, Range(0,5)] public int NeededTorch { get; private set; } = 0;
    [field: SerializeField] public MinMaxInt RewardTorch { get; private set; }
    [field: SerializeField] public int MonsterNum { get; private set; } = 10;
    [field: SerializeField] public EnemyModel MainEnemyModel { get; private set; }
    [field: SerializeField] public Sprite StageMainEnemySprite { get; private set; }
    [field: SerializeField] public RewardModel RewardModel { get; private set; }

}
