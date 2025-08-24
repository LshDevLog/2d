using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen_GameOver_Manager : MonoBehaviour
{
    [SerializeField] private RewardCtrl _rewardCtrl;
    [SerializeField] private BtnUI _returnBtn;

    private void Awake()
    {
        _returnBtn.Add(() => SceneManager.LoadScene("Main"));
    }

    public void PlayerWin()
    {
        _rewardCtrl.GiveReward();
    }

    public void PlayerLose()
    {
        _rewardCtrl.DontGiveReward();
    }
}
