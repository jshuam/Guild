using UnityEngine;

namespace Guild.Core
{
    [CreateAssetMenu(fileName = "New Item", menuName = "Item")]
    public class Item : ScriptableObject
    {
        [SerializeField] private Sprite _sprite = null;
        [SerializeField] private string _name = "";

        public Sprite Sprite { get => _sprite; }
        public string Name { get => _name; }
    }
}