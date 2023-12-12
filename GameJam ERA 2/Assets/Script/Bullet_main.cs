using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet_main : MonoBehaviour
{

    [SerializeField]
    private float horizontalspeed;
    private Rigidbody2D rb2d;
    [SerializeField]
    private int hitAmount = 1;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(horizontalspeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == "Enemy")
        {
            var health = collision.gameObject.GetComponent<Health>();

            health.Hit(hitAmount);
            Destroy(gameObject);
        }
    }
}
