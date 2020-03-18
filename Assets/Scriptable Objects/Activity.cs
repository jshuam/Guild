using UnityEngine;

namespace Guild.Core
{
    [CreateAssetMenu(fileName = "New Activity", menuName = "Activity")]
    public class Activity : ScriptableObject
    {
        [SerializeField] private float _energyCost = 0f;
        [SerializeField] private float _radius = 0f;
        [SerializeField] private ItemPickup _reward = null;
        [SerializeField] private ActivityType _activityType = null;

        public ActivityType ActivityType { get => _activityType; }
        public float EnergyCost { get => _energyCost; }
        public float Radius { get => _radius; }
        public ItemPickup Reward { get => _reward; }
    }
}