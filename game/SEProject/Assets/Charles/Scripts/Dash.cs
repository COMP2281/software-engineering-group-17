using System.Collections;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private float dashForce = 25f;
    public bool canDash = false;
    public bool isDashing = false;
    private float dashTime = 0.10f;
    private float dashCooldown = 0.5f;
    private bool left;
    private bool right;
    private bool up;
    private bool down;
    public Rigidbody2D rb;
    float x;
    float y;

    void Update()
    {
        // rb.velocity = velocity;
        if (canDash && Input.GetKeyDown("space")) {
            up = gameObject.GetComponent<PlayerMovement2>().up;
            down = gameObject.GetComponent<PlayerMovement2>().down;
            right = gameObject.GetComponent<PlayerMovement2>().right;
            left = gameObject.GetComponent<PlayerMovement2>().left;
            StartCoroutine(StartDash(up, down, left, right));
        }    
    }

    IEnumerator StartDash(bool up, bool down, bool left, bool right) {
        canDash = false;
        isDashing = true;

        if (up) {
            y = 1;
        }

        else if (down) {
            y = -1;
        }

        if (right) {
            x = 1;
        }

        else if (left) {
            x = -1;
        }

        if (x != 0 && y != 0){
            x = x/Mathf.Sqrt(2);
            y = y/Mathf.Sqrt(2);
        }

        rb.velocity = new Vector2(x*dashForce, y*dashForce);
        yield return new WaitForSeconds(dashTime);
        isDashing = false;
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;

        x = 0;
        y = 0;
    }
}
