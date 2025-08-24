#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(TextModel))]
public class TextModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- TextModel은 버튼에 있는 텍스트와 같은 고정된 UI의 Text데이터입니다.\n" +
            "- TextModel은 직접 생성할 필요가 없습니다.\n" +
            "- 원하는 Text의 TextModel에 들어있는 InputString을 교체하면 해당 Text의 내용이 변경됩니다.\n" +
            "- InputString은 영어로 작성해주세요.\n" +
            "- DelayTime은 한 글자씩 출력하는 연출에서 사용됩니다.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
