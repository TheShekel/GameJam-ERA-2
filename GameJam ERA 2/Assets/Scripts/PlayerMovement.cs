using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField] private float speed = 5.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if (h != 0.0f)
            rigidBody.velocity = new Vector2(h * speed, 0.0f);

        float v = Input.GetAxis("Vertical");
        if (v != 0.0f)
            rigidBody.velocity = new Vector2(0.0f, v * speed);
    }
}
