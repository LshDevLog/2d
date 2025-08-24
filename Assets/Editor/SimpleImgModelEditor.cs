#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(SimpleImgModel))]
public class SimpleImgModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- SimpleImgModel�� ���� ������ �ʿ䰡 �����ϴ�.\n" +
            "- ���ϴ� UI�� SimpleImgModel�� ����ִ� IconSprite�� ��ü�ϸ� �ش� UI�� �̹����� ����˴ϴ�.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
