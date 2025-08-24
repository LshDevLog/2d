#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(EnemyModel))]
public class EnemyModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- EnemyModel�� ������ �� �����͸� �Է��ϰ� ������ StageModel�� MainEnemyModel�� �־��ּ���.\n" +
            "- Name�� ����� �ۼ����ּ���.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
