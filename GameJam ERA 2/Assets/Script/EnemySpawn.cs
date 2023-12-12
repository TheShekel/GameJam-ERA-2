using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] 
    private GameObject Enemy_Large_Sprite1, Enemy_Medium_Sprite1, Enemy_Small_Sprite1;
    private int enemyType;
    [SerializeField] private Transform tf;
    [SerializeField] private float timer;
    [SerializeField] private float rand;

    private scoreBoardController scoreBoardController;
    // Start is called before the first frame update
    void Start()
    {
        enemyType = Random.Range(1, 4);
        rand = Random.Range(1f, 5f);
        timer = rand;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        spawn();
       
    }
    private void spawn()
    {
        float randaxis = Random.Range(-4, 4);
        if(timer < 0)
        {
            if (enemyType == 1)
            {
                Instantiate(Enemy_Medium_Sprite1, new Vector3(tf.position.x, tf.position.y + randaxis, tf.position.z) , tf.rotation);
                enemyType= Random.Range(1, 4);
            }
            else if(enemyType == 2)
            {
                Instantiate(Enemy_Small_Sprite1, new Vector3(tf.position.x, tf.position.y + randaxis, tf.position.z), tf.rotation);
                enemyType = Random.Range(1, 4);
            }
            else
            {
                Instantiate(Enemy_Large_Sprite1, new Vector3(tf.position.x, tf.position.y + randaxis, tf.position.z), tf.rotation);
                enemyType = Random.Range(1, 4);
            }
            
            rand = Random.Range(1f,5f);
            timer = rand;
        }

    }

    // private void OnBecameInvisible()
    // {
    //     if (scoreBoardController.Score >= 25)
    //     {
    //         Instantiate(Enemy_Boss_Sprite1, tf.position, tf.rotation);
    //     }
    // }

}
