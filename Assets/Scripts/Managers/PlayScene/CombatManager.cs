using System.Collections;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public static CombatManager Instance {  get; private set; }

    [SerializeField] private Screen_Combat_Manager _screenCombatManager;
    [SerializeField] private Screen_GameOver_Manager _screenGameOverManager;
    [SerializeField] private PlayerCombatCtrl _player;
    [SerializeField] private EnemyCombatCtrl _enemy;

    private StageModel _stageModel;
    private bool IsOver = false;
    public int KillCount { get; private set; } = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _stageModel = GameTempDataContainer.Instance.GetCurStageModel();
        StartCoroutine(nameof(CoBattle));
    }

    private IEnumerator CoBattle()
    {
        _enemy.Init(_stageModel.MainEnemyModel);

        while (!IsOver)
        {
            if (_player.IsAttackable)
            {
                _player.Attack(_enemy);
                if (_enemy.IsDead)
                {
                    ++KillCount;
                    _screenCombatManager.SetStageProgress();
                    if (KillCount < _stageModel.MonsterNum)
                    {
                        SpawnNewEnemy();
                    }
                    else
                    {
                        IsOver = true;
                    }
                }
            }

            if (_enemy.IsAttackable)
            {
                _enemy.Attack(_player);
                if (_player.IsDead)
                {
                    IsOver = true;
                }
            }

            yield return null;
        }

        EndCombat();
    }

    private void SpawnNewEnemy()
    {
        _enemy.Init(_stageModel.MainEnemyModel);
    }

    private void EndCombat()
    {
        _enemy.ClearCharacterArea();
        _player.StopAllCoroutines();
        _enemy.StopAllCoroutines();
        if (!_player.IsDead)
        {
            PlayerWin();
        }
        else
        {
            PlayerLose();
        }
        _screenGameOverManager.gameObject.SetActive(true);
    }

    private void PlayerWin()
    {
        _screenGameOverManager.PlayerWin();
    }

    private void PlayerLose()
    {
        _screenGameOverManager.PlayerLose();
    }
}
