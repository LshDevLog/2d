#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(TextModel))]
public class TextModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- TextModel�� ��ư�� �ִ� �ؽ�Ʈ�� ���� ������ UI�� Text�������Դϴ�.\n" +
            "- TextModel�� ���� ������ �ʿ䰡 �����ϴ�.\n" +
            "- ���ϴ� Text�� TextModel�� ����ִ� InputString�� ��ü�ϸ� �ش� Text�� ������ ����˴ϴ�.\n" +
            "- InputString�� ����� �ۼ����ּ���.\n" +
            "- DelayTime�� �� ���ھ� ����ϴ� ���⿡�� ���˴ϴ�.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
