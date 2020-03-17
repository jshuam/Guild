using UnityEngine;

namespace Guild.Core
{
    [CreateAssetMenu(fileName = "New Health Value", menuName = "Health Value")]
    public class Health : ScriptableObject
    {
        [SerializeField] private float _maxHealth = 0f;

        public float MaxHealth { get => _maxHealth; }
    }
}