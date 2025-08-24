using UnityEngine;

[CreateAssetMenu(menuName = "Game/StatModel")]
public class StatModel : ScriptableObject
{
    [field: SerializeField] public Sprite _iconSprite;
    [field: SerializeField] public string _statName;
    [field: SerializeField] public float _statPerLevel;
    [field: SerializeField] public bool IsStatFloatValue;
}
