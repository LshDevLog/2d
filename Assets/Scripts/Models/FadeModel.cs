using UnityEngine;

[CreateAssetMenu(menuName = "Game/FadeModel")]
public class FadeModel : ScriptableObject
{
    [field: SerializeField] public float FadeDuration { get; private set; } = 1f;
    [field: SerializeField] public float DisplayTime { get; private set; } = 2f;
}
