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

            if(movement.x > 0 )
            {
                anim.SetTrigger("right");
            }
            else if(movement.x < 0){
                anim.SetTrigger("left");
            }
            else if(movement.y < 0)
            {
                anim.SetTrigger("forward");
            }
            else if (movement.y > 0)
            {
                anim.SetTrigger("backward");
            }
            else
            {
                anim.SetTrigger("idle");
            }
        }
        else
        {
            movement.x = 0;
            movement.y = 0;
        }
        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
