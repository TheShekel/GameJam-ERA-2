using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float currenthealth;

    [SerializeField]
    private float MaxHealth;


    public void Hit( float hitAmount)
    {
        if (currenthealth == 0) 
        {
            return;
        }

        currenthealth -= hitAmount;

        if (currenthealth < 0)
        {
            currenthealth = 0;
        }
    }
}
