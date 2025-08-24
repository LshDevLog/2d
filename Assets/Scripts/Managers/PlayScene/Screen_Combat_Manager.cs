using UnityEngine;

public class Screen_Combat_Manager : MonoBehaviour
{
    [SerializeField] private PlayerCombatCtrl _playerCtrl;
    [SerializeField] private CharacterAreaCtrl _playerArea;
    [SerializeField] private CharacterAreaCtrl _enemyArea;
    [SerializeField] private ProgressCtrl _stageProgress;
    [SerializeField] private PotionCtrl _potionCtrl;

    private void Start()
    {
        _potionCtrl.InitPotionBtn(OnClickPotionBtn);
        _potionCtrl.SetRemainingPotionText(PlayerDataCtrl.Instance.GetPoitonNum());
        SetStageProgress();
    }

    public void OnClickPotionBtn()
    {
        if(_playerCtrl.PotionNum > 0)
        {
            _playerCtrl.UsePotion();
            _potionCtrl.SetRemainingPotionText(_playerCtrl.PotionNum);
            if(_playerCtrl.PotionNum <= 0)
            {
                _potionCtrl.DisableButton();
            }
        }
    }

    public void SetStageProgress()
    {
        _stageProgress.UpdateGauge(CombatManager.Instance.KillCount, GameTempDataContainer.Instance.GetCurStageModel().MonsterNum);
    }
}
