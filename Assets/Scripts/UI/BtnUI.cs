using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BtnUI : MonoBehaviour
{
    [SerializeField] private Button _btn;

    private void Awake()
    {
        if(_btn == null)
            _btn = GetComponent<Button>();
    }

    public void Add(UnityAction action)
    {
        _btn.onClick?.RemoveAllListeners();
        _btn.onClick.AddListener(action);
    }

    public void Remove(UnityAction action)
    {
        _btn.onClick?.RemoveListener(action);
    }

    public void Clear()
    {
        _btn.onClick?.RemoveAllListeners();
    }

    public void InteractableBtn()
    {
        _btn.image.color = Color.white;
        _btn.interactable = true;
    }

    public void DisableBtn()
    {
        _btn.image.color = Color.red;
        _btn.interactable = false;
    }
}
