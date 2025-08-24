#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(StageModel))]
public class StageModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- Stage Name은 영어로 작성해주세요.\n" +
            "- Stage Order Number는 스테이지의 순서를 의미합니다. 첫 번째 스테이지는 0입니다.\n" +
            "- Needed Torch은 해당 스테이지를 진행하기 위한 Torch 개수입니다.\n" +
            "- Needed Torch은 화면과 Torch UI의 크기를 고려하여 최대 5개로 제한되어있습니다.\n" +
            "- Reward Torch는 스테이지 클리어 후 보상으로 획득하는 Torch의 개수입니다.\n" +
            "- Monster Num은 해당 스테이지에 등장하는 몬스터의 수 입니다.\n" +
            "- Stage Main Enemy Sprite에는 해당 스테이지에 등장하는 메인 몬스터의 이미지를 넣어주세요.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
