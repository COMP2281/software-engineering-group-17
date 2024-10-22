using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerMovement2 : MonoBehaviour
{
    public static PlayerMovement2 PlayerMovement;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
 

    public bool canMove = true;

    public Animator anim;

    private bool facingRight = true;

    private bool isfrozen = false;

    public bool left = false;
    public bool right = false;
    public bool up = false;
    public bool down = false;

    public float unfreezetime = 5f;

    private bool freezingcold = false;

    private float freeztimer = 10f;

    public AudioSource freezing;

    private bool overloadstopper;

    
    // Start is called before the first frame update
    void Start()
    {
        
        //rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();

    }

    // Update is called once per frame (framrate dependent)
    void Update()
    {
        if (canMove)
        {
            
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            if (movement.x > 0)
            {
                right = true;
                left = false;
            }
            else if (movement.x < 0)
            {
                left = true;
                right = false;
            }
            else
            {
                left = false;
                right = false;
            }

            if (movement.y > 0)
            {
                up = true;
                down = false;
            }
            else if (movement.y < 0)
            {
                down = true;
                up = false;
            }
            else
            {
                down = false;
                up = false;
            }
        }
        else if (!canMove && isfrozen)
        {
            if (right)
            {
                movement.x = 1;
            }
            else if (left)
            {
                movement.x = -1;
            }

            if (up)
            {
                movement.y = 1;
            }
            else if (down)
            {
                movement.y = -1;
            }
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
        
        if(freezingcold)
        {
            freeztimer -= Time.deltaTime;
            if (freeztimer <= 0)
            {
 
                //freezing.Play();
                if (overloadstopper)
                {
                    overloadstopper = false;
                    freezing.Play();
                    
                }
                StartCoroutine(Frozen());
                
            }
        }
        else
        {
            freeztimer = 10f;
        }
    }

    void FixedUpdate()
    {
        
        if (!gameObject.GetComponent<Dash>().isDashing) {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("ice"))
        {
            freezingcold = true;
            isfrozen = true;
            canMove = false;
            StartCoroutine(Unfreeze());
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("ice"))
        {
            freezingcold = false;
            isfrozen = false;
            canMove = true;
            //StartCoroutine(Unfreeze());
        }
    }

    IEnumerator Unfreeze()
    {
        if (isfrozen)
        {
            yield return new WaitForSeconds(unfreezetime);
            canMove = true;
            isfrozen = false;
        }
    }

    IEnumerator Frozen()
    {
        
        canMove = false;
        yield return new WaitForSeconds(5);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

