using UnityEngine;

namespace Guild.Core
{
    [RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 0f;
        private Rigidbody2D _rb;
        private Animator _animator;
        private Vector2 _movement;

        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

        void Update()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");

            _animator.SetFloat("Speed", _movement.sqrMagnitude);

            if (_movement != Vector2.zero)
            {
                _animator.SetFloat("Horizontal", _movement.x);
                _animator.SetFloat("Vertical", _movement.y);
            }

        }

        void FixedUpdate()
        {
            _rb.MovePosition(_rb.position + _movement.normalized * Time.deltaTime * _speed);
        }
    }
}