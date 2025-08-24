using UnityEngine;

[CreateAssetMenu(menuName = "Game/PlayerCombatBaseStatsModel")]
public class PlayerCombatBaseStatsModel : ScriptableObject
{
    [field: SerializeField] public Sprite PlayerSprite { get; private set; }
    [field: SerializeField, Min(1)] public int Health { get; private set; } = 5;
    [field: SerializeField, Min(1)] public int Attack { get; private set; } = 1;
    [field: SerializeField, Range(0, 99f)] public float Defence { get; private set; } = 5f;
    [field: SerializeField, Range(0.1f, 0.9f)] public float Speed { get; private set; } = 0.1f;
}
