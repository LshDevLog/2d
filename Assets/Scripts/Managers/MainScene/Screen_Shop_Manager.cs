using UnityEngine;

public class Screen_Shop_Manager : MonoBehaviour
{
    [SerializeField] private ShopSlotCtrl[] _slots;

    private void Start()
    {
        for (int i = 0; i < _slots.Length; ++i)
        {
            _slots[i].InitSlot();
        }
    }
}
