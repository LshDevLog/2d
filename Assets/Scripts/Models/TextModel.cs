using UnityEngine;

[CreateAssetMenu(menuName = "Game/TextModel")]
public class TextModel : ScriptableObject
{
    [field: SerializeField] public string InputString { get; private set; } = string.Empty;
    [field: SerializeField] public float DelayTime { get; private set; } = 0.1f;

}
