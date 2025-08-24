using UnityEngine;

public class BtmMenuUIManager : MonoBehaviour
{
    [SerializeField] private BtnUI _shopBtn;
    [SerializeField] private BtnUI _adventureBtn;
    [SerializeField] private BtnUI _inventoryBtn;

    private void Start()
    {
        InitBtns();
    }

    public void InitBtns()
    {
        _shopBtn.Add(MainSceneScreenManager.Instance.OpenShopScreen);
        _adventureBtn.Add(MainSceneScreenManager.Instance.OpenAdeventureScreen);
        _inventoryBtn.Add(MainSceneScreenManager.Instance.OpenInventoryScreen);
    }
}
