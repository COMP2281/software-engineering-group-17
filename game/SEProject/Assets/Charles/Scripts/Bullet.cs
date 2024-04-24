using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public float x = 0f;
    public float y = 0f;
    
    // Update is called once per frame
    void Update()
    {
        rb.velocity =  y * speed * transform.up + x * speed * transform.right;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here

        if (other.gameObject == player)
        {
            if (!player.GetComponent<Dash>().isDashing){
                player.GetComponent<Lives>().DamagePlayer();
            } 
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Collide")
        {
            // Debug.Log(other)
            Destroy(gameObject);
        }
    }
}
