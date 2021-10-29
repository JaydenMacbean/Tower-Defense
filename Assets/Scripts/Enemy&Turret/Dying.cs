using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour
{
    [SerializeField] private float _startHealth;
    private float _currentHealth;
    private void Start()
    {
        _currentHealth = _startHealth;
    }

    public void TakeDamage(float amount)
    {

        _currentHealth -= amount;

        if (_currentHealth <= 0)
        {
            Death();
        }
    }

    public virtual void Death()
    {
        Destroy(gameObject);
    }
}
