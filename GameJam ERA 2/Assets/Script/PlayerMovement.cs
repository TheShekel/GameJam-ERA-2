using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using System.Xml.Serialization;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float bulletSpawnSpeed;
    private float bulletSpawn;
    public float speed;
    private  Rigidbody2D rb2d;
    bool isCollideBullet;
    public GameObject bullet;
    private SpriteRenderer render;
    public GameObject player;
    private bool isBulletCoolDown;
    public bool isPlayerInvincible;
    public float invincibleTimer = 2.0f;
    bool isCollideWall;
    //private float a;
    private Vector3 location;
    public Vector3 size;
    private Collider2D col;
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpawn = bulletSpawnSpeed;
        render = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        size = col.bounds.size;
        //Debug.Log(size);


    }

    // Update is called once per frame
    void Update()
    {
        location = transform.position;

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
        if (collision.gameObject.tag == "Bullet" && !isPlayerInvincible ||
            collision.gameObject.tag == "Enemy" && !isPlayerInvincible)
        {
            isPlayerInvincible = true;
            Debug.Log("hit");
            health -= 1;
            Destroy(collision.gameObject);

        }

    }

    private void SpawnBullet()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            Instantiate(bullet, new Vector3(location.x + size.x + 0.1f, location.y, 0), Quaternion.identity);
            isBulletCoolDown = true;

        }
    }
    private void CanSpawnBullet()
    {
        if (isBulletCoolDown)
        {
            bulletSpawn -= Time.deltaTime;
        }
        if(bulletSpawn < 0)
        {
            bulletSpawn = bulletSpawnSpeed;
            isBulletCoolDown = false;
        }
    }

    private void counter()
    {
        invincibleTimer -= Time.deltaTime;
    }

    private void PlayerHit(bool playerHit)
    {
        if (playerHit)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
            {
                player.GetComponent<SpriteRenderer>().enabled = true;
                invincibleTimer = 2.0f;
                isPlayerInvincible = false;
            }
        }
    }


}
