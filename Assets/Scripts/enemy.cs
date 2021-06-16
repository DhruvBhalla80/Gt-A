using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int EnemySpeed ;
    public int XMoveDirection;
    

    void Update()
    {
       
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * EnemySpeed;
      
     }

    private void OnCollisionEnter2D(Collision2D target)

    {

       
        if (target.gameObject.tag.Equals("Boxes") == true)

        {
            if (XMoveDirection > 0 || XMoveDirection > 1)

            {

                XMoveDirection = -1;

            }

            else

            {

                XMoveDirection = 1;

            }

        }

    }
}
