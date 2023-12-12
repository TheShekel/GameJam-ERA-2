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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_health.IsInvincible)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Bullet" && !_health.IsInvincible ||
            collision.gameObject.tag == "Enemy" && !_health.IsInvincible)
        {
            Debug.Log("hit");
            Destroy(collision.gameObject);
        }
    }
}
