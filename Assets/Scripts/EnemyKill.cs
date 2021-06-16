using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    public GameObject Enemy;
    
    void Start()
    {
     Enemy = gameObject.transform.parent.gameObject;
    }

      
     private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.tag == "Player" )
        {
            Debug.Log("Collision with enemy head");
            Enemy.transform.position = new Vector3(0, -1000, 0);
        }
    }
    

    
}

