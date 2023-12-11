using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class WavyEnemyMov : MonoBehaviour
{
    [SerializeField]
    private float horizontalspeed;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float height;
    private Rigidbody2D rb2d;
    private Vector3 pos;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }

    void FixedUpdate()
    {
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        rb2d.velocity = new Vector2(-horizontalspeed, newY);
    }
}
