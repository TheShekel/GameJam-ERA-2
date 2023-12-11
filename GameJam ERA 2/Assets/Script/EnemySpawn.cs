using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemy_vanguard,enemy_fighter,enemy_brute;
    private int enemyType;
    [SerializeField] private Transform tf;
    [SerializeField] private float timer;
    [SerializeField] private float rand;
    // Start is called before the first frame update
    void Start()
    {
        enemyType = Random.Range(1, 4);
        rand = Random.Range(1f, 10f);
        timer = rand;
    }

    // Update is called once per frame
    void Update()
    {
        
        spawn();
       
    }
    private void spawn()
    {
        timer-= Time.deltaTime;
        if(timer < 0)
        {
            if (enemyType == 1)
            {
                Instantiate(enemy_vanguard, tf.position, tf.rotation);
                enemyType=Random.Range(1, 4);
            }
            else if(enemyType == 2)
            {
                Instantiate(enemy_fighter, tf.position, tf.rotation);
                enemyType = Random.Range(1, 4);
            }
            else
            {
                Instantiate(enemy_brute, tf.position, tf.rotation);
                enemyType = Random.Range(1, 4);
            }
            
            rand = Random.Range(1f,10f);
            timer = rand;
        }
        

    }
    
    
}
