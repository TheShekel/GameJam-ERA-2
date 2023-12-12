using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    public int currenthealth;

    [SerializeField]
    private int MaxHealth;

    public bool IsInvincible;

    public UnityEvent OnDeath;

    public UnityEvent OnDamaged;

    public void Hit()
    {
        if (currenthealth == 0)
        {
            return;
        }

        if (IsInvincible)
        {
            return;
        }

        currenthealth -= 1;

        if (currenthealth < 0)
        {
            currenthealth = 0;
        }

        if (currenthealth == 0)
        {
            OnDeath.Invoke();
            Destroy(gameObject);
            if(gameObject.tag == "Enemy"){
                ScoreUI.AddScore(MaxHealth);
            }
        }
        else
        {
            OnDamaged.Invoke();
        }
    }

}
