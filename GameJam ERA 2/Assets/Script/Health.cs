using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health;

    public int GetHealth(){
        return health;
    }

    public void Hit(){
        health -= 1;
        if(health <= 0){
            health = 0;
            Destroy(gameObject);
        }
    }
}
