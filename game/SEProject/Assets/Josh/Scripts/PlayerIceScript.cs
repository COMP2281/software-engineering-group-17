using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerIceScript : MonoBehaviour
{
    public static PlayerIceScript playerIceScript;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;


    public bool canMove = true;

    public Animator anim;

    private bool facingRight = true;

    private bool isFrozen = false;

    private bool left = false;
    private bool right = false;
    private bool up = false;
    private bool down = false;

    public float unfreezeTime = 5f;

    public AudioSource freezing;

    private bool overloadStopper;

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
        else if (!canMove && isFrozen)
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("ice"))
        {
            
            isFrozen = true;
            canMove = false;
            //StartCoroutine(Unfreeze());
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("ice"))
        {
            
            isFrozen = false;
            canMove = true;
            //StartCoroutine(Unfreeze());
        }
    }

    IEnumerator Unfreeze()
    {
        if (isFrozen)
        {
            yield return new WaitForSeconds(unfreezeTime);
            canMove = true;
            isFrozen = false;
        }
    }

    IEnumerator Frozen()
    {

        canMove = false;
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

