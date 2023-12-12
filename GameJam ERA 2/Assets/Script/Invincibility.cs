using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    public void StartInvincibility(float invincibilityDuration)
    {
        StartCoroutine(InvinicbilityCoroutine(invincibilityDuration));
    }

    private IEnumerator InvinicbilityCoroutine(float invincibilityDuration)
    {
        _health.IsInvincible = true;
        yield return new WaitForSeconds(invincibilityDuration);
        _health.IsInvincible = false;
    }
}
