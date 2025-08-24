using System.Collections;
using UnityEngine;

public class PlayerCombatCtrl : CombatableEntity
{
    public int PotionNum {  get; private set; }
    private int _potionHealAmount;

    private void Start()
    {
        Init();
        StartCoroutine(nameof(CoUpdateCoolTimeUI));
    }

    public void Init()
    {
        _hpMax = PlayerDataCtrl.Instance.GetHP();
        _curHp = _hpMax;
        _attack = PlayerDataCtrl.Instance.GetAttack();
        _defence = PlayerDataCtrl.Instance.GetDefence();
        _speed = PlayerDataCtrl.Instance.GetSpeed();
        _coolTime = 0f;
        PotionNum = PlayerDataCtrl.Instance.GetPoitonNum();
        _potionHealAmount = PlayerDataCtrl.Instance.GetPotionHealAmount();
        _characterArea.InitCharacterArea(PlayerDataCtrl.Instance.GetPlayerSprite(), _attack, _defence, _speed, _hpMax);
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

    public void UsePotion()
    {
        --PotionNum;
        _curHp += _potionHealAmount;
        _curHp = Mathf.Min(_curHp, _hpMax);
        _characterArea.UpdateHpBar(_curHp, _hpMax);
    }
}
