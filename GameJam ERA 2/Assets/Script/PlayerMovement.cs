using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private  Rigidbody2D rb2d;
    bool isCollideBullet;
    bool isCollideWall;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb2d.velocity = new Vector2(0, moveVertical * speed);
        if (isCollideBullet)
        {
            Debug.Log("hit");
            isCollideBullet = false;
        }

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            isCollideBullet = true;
            Destroy(collision.gameObject);

        }

    }

}
