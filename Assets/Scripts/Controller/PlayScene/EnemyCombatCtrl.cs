using System.Collections;
using UnityEngine;

public class EnemyCombatCtrl : CombatableEntity
{

    private void Start()
    {
        StartCoroutine(nameof(CoUpdateCoolTimeUI));
    }

    public void Init(EnemyModel enemyModel)
    {
        _hpMax = Random.Range(enemyModel.Health.Min, enemyModel.Health.Max + 1);
        _curHp = _hpMax;
        _attack = Random.Range(enemyModel.Attack.Min, enemyModel.Attack.Max + 1);
        _defence = Random.Range(enemyModel.Defence.Min, enemyModel.Defence.Max);
        _speed = Random.Range(enemyModel.Speed.Min, enemyModel.Speed.Max);
        _coolTime = 0f;
        _characterArea.InitCharacterArea(enemyModel.ImgSprite, _attack, _defence, _speed, _hpMax);
        StartCoolTime();
    }

    private IEnumerator CoUpdateCoolTimeUI()
    {
        while (true)
        {
            _characterArea.UpdateCoolTimeProgress(_coolTime, 1f);
            yield return null;
        }
    }

    protected override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        _characterArea.UpdateHpBar(_curHp, _hpMax);
    }

    public void ClearCharacterArea()
    {
        _characterArea.ClearCharacterArea();
    }
}
