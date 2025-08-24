#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(EnemyModel))]
public class EnemyModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- EnemyModel을 생성한 뒤 데이터를 입력하고 출현할 StageModel의 MainEnemyModel에 넣어주세요.\n" +
            "- Name은 영어로 작성해주세요.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
