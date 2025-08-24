#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(StageConfig))]
public class StageConfigEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- StageConfig의 개수를 1개로 유지해주세요.\n" +
            "- StageModel을 생성한 후 데이터를 입력하고 StageModelArr에 넣으면 스테이지가 구현됩니다.\n" +
            "- StageModelArr에 StageModel을 순서에 맞게 넣어주세요.\n" +
            "- StageModel의 추가, 제거는 자유롭게 가능합니다.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
