using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float currenthealth;

    [SerializeField]
    private float MaxHealth;

    public bool IsInvincible { get; set; }

    public UnityEvent OnDeath;

    public UnityEvent OnDamaged;

    public void Hit(float hitAmount)
    {
        if (currenthealth == 0)
        {
            return;
        }

        if (IsInvincible)
        {
            return;
        }

        currenthealth -= hitAmount;

        if (currenthealth < 0)
        {
            currenthealth = 0;
        }

        if (currenthealth == 0)
        {
            OnDeath.Invoke();
            Destroy(gameObject);
        }
        else
        {
            OnDamaged.Invoke();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsInvincible)
        {

            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Bullet" && !IsInvincible ||
            collision.gameObject.tag == "Enemy" && !IsInvincible)
        {
            Debug.Log("hit");
            Destroy(collision.gameObject);
        }
    }

}
