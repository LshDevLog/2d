#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(SimpleImgModel))]
public class SimpleImgModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- SimpleImgModel은 직접 생성할 필요가 없습니다.\n" +
            "- 원하는 UI의 SimpleImgModel에 들어있는 IconSprite를 교체하면 해당 UI의 이미지가 변경됩니다.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
