#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(PlayerCombatBaseStatsModel))]
public class PlayerCombatBaseStatsModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- �÷��̾��� �߰� �ɷ�ġ���� ������� ���� ���� ���̽� �ɷ�ġ�Դϴ�.\n" +
            "- �� �ɷ�ġ�� �÷��̾��� �߰� �ɷ�ġ���� ������ ���·� ������ �����մϴ�.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
