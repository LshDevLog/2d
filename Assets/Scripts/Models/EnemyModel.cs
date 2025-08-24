using UnityEngine;

[CreateAssetMenu(menuName = "Game/EnemyModel")]
public class EnemyModel : ScriptableObject
{
    [field: SerializeField] public Sprite ImgSprite { get; private set; }
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public MinMaxInt Health { get; private set; }
    [field: SerializeField] public MinMaxInt Attack { get; private set; }
    [field: SerializeField] public MinMaxFloat Defence { get; private set; }
    [field: SerializeField] public MinMaxFloat Speed { get; private set; }
}
