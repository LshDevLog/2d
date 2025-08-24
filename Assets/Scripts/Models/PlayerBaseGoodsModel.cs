using UnityEngine;

[CreateAssetMenu(menuName = "Game/PlayerBaseGoodsModel")]
public class PlayerBaseGoodsModel : ScriptableObject
{
    [field: SerializeField] public int Gold { get; private set; } = 5;
    [field: SerializeField] public int Gem { get; private set; } = 0;
    [field: SerializeField] public int Torch { get; private set; } = 0;
}
