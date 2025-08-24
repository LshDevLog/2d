
[System.Serializable]
public class PlayerData
{
    public PlayerGoods PlayerGoods;
    public PlayerUpgrade PlayerUpgrade;

    public PlayerData()
    {
        PlayerGoods = new PlayerGoods();
        PlayerUpgrade = new PlayerUpgrade();
    }
}

[System.Serializable]
public class PlayerGoods
{
    public int Gold = 0;
    public int Gem = 0;
    public int Torch = 1;
}

[System.Serializable]
public class PlayerUpgrade
{
    public int HealthPointLevel = 1;
    public int AttackLevel = 1;
    public int DefenceLevel = 1;
    public int SpeedLevel = 1;
    public int PotionNumLevel = 1;
    public int PotionAmountLevel = 1;
}