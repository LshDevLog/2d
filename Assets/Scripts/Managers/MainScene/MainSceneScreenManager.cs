using System.Collections;
using UnityEngine;

public class MainSceneScreenManager : MonoBehaviour
{
    public static MainSceneScreenManager Instance { get; private set; }

    [Header("IntroScreensArea")]
    [SerializeField] private GameObject _introArea;
    [SerializeField] private GameObject _splashScreen;
    [SerializeField] private GameObject _introMenuScreen;
    [SerializeField] private FadeCtrl _fadeCtrl;
    [SerializeField] private TextCtrl _titleTxtCtrl;

    [Header("MainScreensArea")]
    [SerializeField] private GameObject _mainArea;
    [SerializeField] private GameObject _shopScreen;
    [SerializeField] private GameObject _adventureScreen;
    [SerializeField] private GameObject _inventoryScreen;
    [SerializeField] private Screen_Adventure_Manager _screen_Adventure_Manager;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        if (GameTempDataContainer.Instance.IsFirstGameExecution)
        {
            OpenIntroArea();
        }
        else
        {
            OpenMainArea();
            _screen_Adventure_Manager.InitAdventureScreen();
        }
    }

    private void OpenIntroArea()
    {
        GameTempDataContainer.Instance.IsFirstGameExecution = false;
        _mainArea.SetActive(false);
        _introMenuScreen.SetActive(false);
        _splashScreen.SetActive(true);
        StartCoroutine(nameof(CoFadeAndShowIntroMenu));
    }

    public void OpenMainArea()
    {
        _introArea.SetActive(false);
        _mainArea.SetActive(true);
    }

    private IEnumerator CoFadeAndShowIntroMenu()
    {
        yield return _fadeCtrl.CoFadeSequence();
        _splashScreen.SetActive(false);
        _introMenuScreen.SetActive(true);
        yield return _titleTxtCtrl.CoTextSequence();
        _screen_Adventure_Manager.InitAdventureScreen();
    }

    public void OpenShopScreen()
    {
        _shopScreen.SetActive(true);
        _adventureScreen.SetActive(false);
        _inventoryScreen.SetActive(false);
    }

    public void OpenAdeventureScreen()
    {
        _shopScreen.SetActive(false);
        _adventureScreen.SetActive(true);
        _inventoryScreen.SetActive(false);
    }

    public void OpenInventoryScreen()
    {
        _shopScreen.SetActive(false);
        _adventureScreen.SetActive(false);
        _inventoryScreen.SetActive(true);
    }
}
