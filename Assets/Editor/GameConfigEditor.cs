#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(GameConfig))]
public class GameConfigEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- GameConfig�� ������ 1���� �������ּ���.\n" +
            "- ������ �⺻ ������ �����մϴ�.\n" +
            "- ��� URL�� ������ ���̺��� csv�� ������ �� �ִ� URL�ּҷ� �Է����ּ���.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
