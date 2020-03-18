using UnityEngine;

namespace Guild.Core
{
    public class ToolBehaviour : MonoBehaviour
    {
        [SerializeField] private Tool _tool = null;
        private Animator _animator = null;
        private bool _isUsingTool = false;
        private Collider2D _activityObject;

        void Start()
        {
            _animator = GetComponent<Animator>();
        }

        void Update()
        {
            if (!_isUsingTool && Input.GetButtonDown("Fire1"))
            {
                UseTool();
            }
        }

        public void UseTool()
        {
            Vector2 point = new Vector2(transform.position.x, transform.position.y);
            _activityObject = Physics2D.OverlapCircle(point, _tool.Activity.Radius);

            if (_activityObject != null
                && _activityObject.TryGetComponent<ActivityTypeBehaviour>(out var activityType)
                && activityType.ActivityType.Type == _tool.Activity.ActivityType.Type)
            {
                _isUsingTool = true;
                _animator.SetBool("IsMining", true);
                Invoke("StopUsingTool", _tool.Speed);
            }
        }

        private void StopUsingTool()
        {
            _animator.SetBool("IsMining", false);
            Instantiate(_tool.Activity.Reward, _activityObject.transform.position, _activityObject.transform.rotation);
            Destroy(_activityObject.gameObject);
        }
    }
}