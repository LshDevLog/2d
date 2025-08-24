using System.Collections;
using UnityEngine;

public class CombatableEntity : MonoBehaviour
{
    [SerializeField] protected CharacterAreaCtrl _characterArea;

    protected int _hpMax;
    protected int _curHp;
    protected int _attack;
    protected float _defence;
    protected float _speed;
    protected float _coolTime;

    public bool IsAttackable => _coolTime >= 1f;
    public bool IsDead => _curHp <= 0;

    protected void StartCoolTime()
    {
        StopCoroutine(nameof(CoChargeCoolTime));
        StartCoroutine(nameof(CoChargeCoolTime));
    }

    protected IEnumerator CoChargeCoolTime()
    {
        while (true)
        {
            _coolTime += _speed * Time.deltaTime;
            yield return null;
        }
    }
    
    protected virtual void TakeDamage(int damage)
    {
        float defence = Random.Range(0, 100);
        if (defence < _defence)
        {
            Debug.Log("방어 성공!");
            _characterArea.ShieldSuccess();
            return;
        }

        _curHp -= damage;
        if(_curHp <= 0)
        {
            _curHp = 0;
        }
    }

    public void Attack(CombatableEntity enemy)
    {
        _coolTime = 0f;
        enemy.TakeDamage(_attack);
        _characterArea.AttackFade();
        Debug.Log($"{enemy.name}을 공격");
    }
}
