using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Serialization;
using UnityEditor.Tilemaps;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private  Rigidbody2D rb2d;
    bool isCollideBullet;
    public GameObject bullet;
    private SpriteRenderer render;
    public GameObject player;
    public float bulletSpawnSpeed = 1.0f;
    private bool isBulletCoolDown;
    private bool isPlayerInvincible;
    private float invincibleTimer = 2.0f;
    bool isCollideWall;
    //private float a;
    private Vector3 location;
    public Vector3 size;
    private Collider2D col;

    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        location = transform.position;
        render = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        size = col.bounds.size;
        //Debug.Log(size);


    }

    // Update is called once per frame
    void Update()
    {

        
       
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb2d.velocity = new Vector2(0, moveVertical * speed);
  /*      if (isCollideBullet)
        {
            Debug.Log("hit");
            isCollideBullet = false;
        }*/
        if (isBulletCoolDown)
        {
            CanSpawnBullet();
        }
        else
        {
            SpawnBullet();
        }
        PlayerHit(isPlayerInvincible);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isPlayerInvincible)
        {
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.tag == "Bullet" && !isPlayerInvincible)
        {
            isPlayerInvincible = true;
            Debug.Log("hit");
            health -= 1;
            Destroy(collision.gameObject);

        }

    }

    private void SpawnBullet()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            
            Instantiate(bullet, new Vector3(location.x + size.x + 0.1f, location.y, 0), Quaternion.identity);
            isBulletCoolDown = true;

        }
    }
    private void CanSpawnBullet()
    {
        if (isBulletCoolDown)
        {
            bulletSpawnSpeed -= Time.deltaTime;
        }
        if(bulletSpawnSpeed <0)
        {
            bulletSpawnSpeed = 1.0f;
            isBulletCoolDown = false;
        }
    }

    private void PlayerHit(bool playerHit)
    {
        if (playerHit)
        {
            invincibleTimer -= Time.deltaTime;

            if (invincibleTimer < 0)
            {
                invincibleTimer = 2.0f;
                isPlayerInvincible = false;
            }
        }
    }
}
