#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(PlayerCombatBaseStatsModel))]
public class PlayerCombatBaseStatsModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- 플레이어의 추가 능력치들이 적용되지 않은 전투 베이스 능력치입니다.\n" +
            "- 이 능력치에 플레이어의 추가 능력치들이 더해진 상태로 전투에 참가합니다.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
