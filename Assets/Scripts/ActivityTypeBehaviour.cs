using UnityEngine;

namespace Guild.Core
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class ActivityTypeBehaviour : MonoBehaviour
    {
        [SerializeField] private ActivityType _activityType = null;

        public ActivityType ActivityType { get => _activityType; }

        void Reset()
        {
            BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();
            boxCollider2D.isTrigger = true;
        }
    }
}