using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpSpeed = 10.0f;
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

       

        var h = Input.GetAxis("Horizontal");

        rigidbody2D.velocity = new Vector2(h * speed, rigidbody2D.velocity.y);


        if (h < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(h>0)
        { 
            spriteRenderer.flipX = false;
        }

        if(Input.GetKeyDown(KeyCode.Space)&& IsGrounded())
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpSpeed);
        }
       
       }
    private bool IsGrounded()
    {
        return rigidbody2D.velocity.y == 0.0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "base")
            isGrounded = true;
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Collision with plant");
            SceneManager.LoadScene("main");
        }
        if (collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("main");
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "base")
            isGrounded = false ;
    }

}
