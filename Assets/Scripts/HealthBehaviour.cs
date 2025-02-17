﻿using UnityEngine;

namespace Guild.Core
{
    public class HealthBehaviour : MonoBehaviour
    {
        [SerializeField] private Health _health = null;

        private float _currentHealth;

        public float CurrentHealth { get => _currentHealth; set => _currentHealth = value; }

        void Start()
        {
            _currentHealth = _health.MaxHealth;
        }

        void Update()
        {
            Debug.Log(_health.MaxHealth);
            CurrentHealth -= 1 * Time.deltaTime;
            Debug.Log(CurrentHealth);
        }
    }

}