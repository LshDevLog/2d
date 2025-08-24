using UnityEngine;

[CreateAssetMenu(menuName = "Game/GameConfig")]
public class GameConfig : ScriptableObject
{
    [field: SerializeField] public string GameTitle { get; private set; } = "Project Hero";
    [field: SerializeField] public string Version { get; private set; } = "v1.0.0";
    [field: SerializeField] public string DataTableURL { get; private set; } = "";
}
