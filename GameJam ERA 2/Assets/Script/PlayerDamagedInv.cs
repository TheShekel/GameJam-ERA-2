using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagedInv : MonoBehaviour
{
    [SerializeField]
    private float invDuration;

    private Invincibility _invincibility;
    private Health _health;

    private void Awake()
    {
        _invincibility = GetComponent<Invincibility>();
    }
    public void StartInv()
    {
        _invincibility.StartInvincibility(invDuration);
    }

    
}
