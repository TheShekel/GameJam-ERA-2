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

    public bool IsInvincible;

    public UnityEvent OnDeath;

    public UnityEvent OnDamaged;

    public void Hit(float hitAmount)
    {
        Debug.Log(currenthealth);
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
        Debug.Log(currenthealth);
    }

}
