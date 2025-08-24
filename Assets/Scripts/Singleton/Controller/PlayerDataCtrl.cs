using UnityEngine;

public class PlayerDataCtrl : MonoBehaviour
{
    public static PlayerDataCtrl Instance {  get; private set; }

    [SerializeField] private PlayerCombatBaseStatsModel _playerCombatBaseStatsModel;
    [SerializeField] private PlayerBaseGoodsModel _playerBaseGoodsModel;

    private const string xorKey = "ProjectHeroeXorKey";
    private const string PLAYER_DATA_KEY = "egfbtjyj";

    private PlayerData _playerData;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadData();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveData()
    {
        SaveLoadSystem.SaveJson(PLAYER_DATA_KEY, _playerData, xorKey);
    }

    public void LoadData()
    {
        _playerData = SaveLoadSystem.LoadJson<PlayerData>(PLAYER_DATA_KEY, xorKey);
        if(!PlayerPrefs.HasKey(PLAYER_DATA_KEY))
        {
            _playerData.PlayerGoods = new PlayerGoods();
            _playerData.PlayerGoods.Gold = _playerBaseGoodsModel.Gold;
            _playerData.PlayerGoods.Gem = _playerBaseGoodsModel.Gem;
            _playerData.PlayerGoods.Torch = _playerBaseGoodsModel.Torch;
            _playerData.PlayerUpgrade = new PlayerUpgrade();
            _playerData.PlayerUpgrade.AttackLevel = 1;
            _playerData.PlayerUpgrade.DefenceLevel = 1;
            _playerData.PlayerUpgrade.SpeedLevel = 1;
            _playerData.PlayerUpgrade.HealthPointLevel = 1;
            _playerData.PlayerUpgrade.PotionNumLevel = 1;
            _playerData.PlayerUpgrade.PotionAmountLevel = 1;
        }
        SaveData();
    }

    public void ChangeGoods(eGoodsType goodsType, int amount)
    {
        switch (goodsType)
        {
            case eGoodsType.Gold:
                _playerData.PlayerGoods.Gold += amount;
                break;
            case eGoodsType.Gem:
                _playerData.PlayerGoods.Gem += amount;
                break;
            case eGoodsType.Torch:
                _playerData.PlayerGoods.Torch += amount;
                break;
            default:
                break;
        }
        if(HUD_TopGoodsManager.Instance != null)
        {
            HUD_TopGoodsManager.Instance.UpdateInfoTxt();
        }
        SaveData();
    }

    public void ChangeStats(eStatsType statsType)
    {
        switch (statsType)
        {
            case eStatsType.Attack:
                _playerData.PlayerUpgrade.AttackLevel = Mathf.Min(5, _playerData.PlayerUpgrade.AttackLevel + 1);
                break;
            case eStatsType.Defence:
                _playerData.PlayerUpgrade.DefenceLevel = Mathf.Min(5, _playerData.PlayerUpgrade.DefenceLevel + 1);
                break;
            case eStatsType.Speed:
                _playerData.PlayerUpgrade.SpeedLevel = Mathf.Min(5, _playerData.PlayerUpgrade.SpeedLevel + 1);
                break;
            case eStatsType.HP:
                _playerData.PlayerUpgrade.HealthPointLevel = Mathf.Min(5, _playerData.PlayerUpgrade.HealthPointLevel + 1);
                break;
            case eStatsType.PotionNum:
                _playerData.PlayerUpgrade.PotionNumLevel = Mathf.Min(5, _playerData.PlayerUpgrade.PotionNumLevel + 1);
                break;
            case eStatsType.PotionAmount:
                _playerData.PlayerUpgrade.PotionAmountLevel = Mathf.Min(5, _playerData.PlayerUpgrade.PotionAmountLevel + 1);
                break;
        }

        SaveData();
    }


    #region GetData
    public Sprite GetPlayerSprite() => _playerCombatBaseStatsModel.PlayerSprite;
    public int GetAttack() => Mathf.Max(1, _playerCombatBaseStatsModel.Attack + _playerData.PlayerUpgrade.AttackLevel);
    public float GetDefence() => Mathf.Clamp(_playerCombatBaseStatsModel.Defence + (_playerData.PlayerUpgrade.DefenceLevel * 2f), 0f, 99f);
    public float GetSpeed() => Mathf.Clamp(_playerCombatBaseStatsModel.Speed + (_playerData.PlayerUpgrade.SpeedLevel * 0.1f), 0.1f, 0.9f);
    public int GetHP() => Mathf.Max(1, _playerCombatBaseStatsModel.Health + _playerData.PlayerUpgrade.HealthPointLevel);
    public int GetPoitonNum() => _playerData.PlayerUpgrade.HealthPointLevel;
    public int GetPotionHealAmount() => _playerData.PlayerUpgrade.PotionAmountLevel * 2;


    public int GetAttackLevel() => _playerData.PlayerUpgrade.AttackLevel;
    public int GetDefenceLevel() => _playerData.PlayerUpgrade.DefenceLevel;
    public int GetSpeedLevel() => _playerData.PlayerUpgrade.SpeedLevel;
    public int GetHPLevel() => _playerData.PlayerUpgrade.HealthPointLevel;
    public int GetPotionNumLevel() => _playerData.PlayerUpgrade.PotionNumLevel;
    public int GetPotionAmountLevel() => _playerData.PlayerUpgrade.PotionAmountLevel;

    public int GetGold() => _playerData.PlayerGoods.Gold;
    public int GetGem() => _playerData.PlayerGoods.Gem;
    public int GetTorch() => _playerData.PlayerGoods.Torch;
    #endregion
}

public enum eGoodsType
{
    Gold,
    Gem,
    Torch
}

public enum eStatsType
{
    Attack,
    Defence,
    Speed,
    HP,
    PotionNum,
    PotionAmount
}