using UnityEngine;

public class Screen_Intro_Manager : MonoBehaviour
{
    [SerializeField] private SimpleImgModel _introCenterModel;
    [SerializeField] private ImageUI _introCenter;
    [SerializeField] private BtnUI _startBtn;

    private void Start()
    {
        InitIntroScreen();
    }

    private void InitIntroScreen()
    {
        _introCenter.SetImage(_introCenterModel._iconSprite);
        _startBtn.Add(MainSceneScreenManager.Instance.OpenMainArea);
    }
}
