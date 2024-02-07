using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;



public class S_player_movement : MonoBehaviour
{
    public static S_player_movement s_player_movement;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public bool canmove = true;

    public Animator anim;

    private bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame (framrate dependent)
    void Update()
    {
        if (canmove) {

            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            

            
        }
        else
        {
            
            movement.x = 0;
            movement.y = 0;
        }


        if (movement.x == 0 && movement.y == 0)
        {
            anim.SetTrigger("idle");
        }
        anim.SetFloat("y movement", movement.y);


        anim.SetFloat("x movement", Mathf.Abs(movement.x));

        if (Mathf.Abs(movement.x) > 0)
        {
            anim.SetBool("x move", true);
        }
        else
        {
            anim.SetBool("x move", false);
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (facingRight == false && movement.x > 0)
        {   
            Flip();
        }
        else if (facingRight == true && movement.x < 0)
        {   
            Flip();
        }

        
        
        
        
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
