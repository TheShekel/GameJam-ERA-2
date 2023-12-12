using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    private Health _health;
    private Animator anim;

    private void Awake()
    {
        _health = GetComponent<Health>();
        anim = GetComponent<Animator>();
    }

    public void StartInvincibility(float invincibilityDuration)
    {
        StartCoroutine(InvinicbilityCoroutine(invincibilityDuration));
    }

    private IEnumerator InvinicbilityCoroutine(float invincibilityDuration)
    {
        _health.IsInvincible = true;
        anim.SetBool("IsDamaged", true);
        yield return new WaitForSeconds(invincibilityDuration);
        anim.SetBool("IsDamaged", false);
        _health.IsInvincible = false;
    }
}
