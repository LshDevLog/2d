using UnityEngine;

[CreateAssetMenu(menuName = "Game/RewardModel")]
public class RewardModel : ScriptableObject
{
    [field: SerializeField] public MinMaxInt GoldAmount { get; private set; }
    [field: SerializeField] public float GemProbability { get; private set; }
    [field: SerializeField] public float TorchProbability { get; private set; }
    [field: SerializeField] public MinMaxInt GemAmount { get; private set; }
    [field: SerializeField] public MinMaxInt TorchAmount { get; private set; }
}
