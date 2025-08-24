#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(GameConfig))]
public class GameConfigEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox(
            "- GameConfig의 개수를 1개로 유지해주세요.\n" +
            "- 게임의 기본 정보를 관리합니다.\n" +
            "- 모든 URL은 데이터 테이블을 csv로 가져올 수 있는 URL주소로 입력해주세요.",
            MessageType.Info);

        base.OnInspectorGUI();
    }
}
#endif
