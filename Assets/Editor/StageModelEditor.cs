#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(StageModel))]
public class StageModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- Stage Name�� ����� �ۼ����ּ���.\n" +
            "- Stage Order Number�� ���������� ������ �ǹ��մϴ�. ù ��° ���������� 0�Դϴ�.\n" +
            "- Needed Torch�� �ش� ���������� �����ϱ� ���� Torch �����Դϴ�.\n" +
            "- Needed Torch�� ȭ��� Torch UI�� ũ�⸦ ����Ͽ� �ִ� 5���� ���ѵǾ��ֽ��ϴ�.\n" +
            "- Reward Torch�� �������� Ŭ���� �� �������� ȹ���ϴ� Torch�� �����Դϴ�.\n" +
            "- Monster Num�� �ش� ���������� �����ϴ� ������ �� �Դϴ�.\n" +
            "- Stage Main Enemy Sprite���� �ش� ���������� �����ϴ� ���� ������ �̹����� �־��ּ���.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
