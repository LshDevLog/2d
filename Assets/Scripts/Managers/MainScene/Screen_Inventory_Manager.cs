using UnityEditor.VersionControl;
using UnityEngine;

public class Screen_Inventory_Manager : MonoBehaviour
{
    [SerializeField] private InvenSlotCtrl _attackSlot;
    [SerializeField] private InvenSlotCtrl _defenceSlot;
    [SerializeField] private InvenSlotCtrl _speedSlot;
    [SerializeField] private InvenSlotCtrl _hpSlot;
    [SerializeField] private InvenSlotCtrl _potionNumSlot;
    [SerializeField] private InvenSlotCtrl _potionAmountSlot;
    [SerializeField] private BtnUI _buyBtn;


    private void Start()
    {
       InitSlots();
        _buyBtn.Add(OnClickButBtn);
    }

    private void InitSlots()
    {
        _attackSlot.Init(PlayerDataCtrl.Instance.GetAttackLevel());
        _defenceSlot.Init(PlayerDataCtrl.Instance.GetDefenceLevel());
        _speedSlot.Init(PlayerDataCtrl.Instance.GetSpeedLevel());
        _hpSlot.Init(PlayerDataCtrl.Instance.GetHPLevel());
        _potionNumSlot.Init(PlayerDataCtrl.Instance.GetPotionNumLevel());
        _potionAmountSlot.Init(PlayerDataCtrl.Instance.GetPotionAmountLevel());
    }

    private void OnClickButBtn()
    {
        if (PlayerDataCtrl.Instance.GetGem() <= 0)
            return;

        PlayerDataCtrl.Instance.ChangeGoods(eGoodsType.Gem, -1);
        eStatsType statsType = (eStatsType)Random.Range(0, 6);
        PlayerDataCtrl.Instance.ChangeStats(statsType);
        InitSlots();
#if UNITY_EDITOR
        Debug.Log($"{statsType} ·¹º§¾÷!");
#endif
    }
}