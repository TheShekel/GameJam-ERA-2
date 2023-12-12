using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class LinearEnemyMov : MonoBehaviour
{
    [SerializeField]
    private float horizontalspeed;
    private Rigidbody2D rb2d;
    [SerializeField]
    private int health;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(-horizontalspeed, 0);
    }
}
