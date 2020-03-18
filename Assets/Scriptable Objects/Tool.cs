using UnityEngine;

namespace Guild.Core
{
    [CreateAssetMenu(fileName = "New Tool", menuName = "Tool")]
    public class Tool : ScriptableObject
    {
        [SerializeField] private Sprite _sprite = null;
        [SerializeField] private float _speed = 0f;
        [SerializeField] private Activity _activity = null;

        public float Speed { get => _speed; }
        public Activity Activity { get => _activity; }
    }
}