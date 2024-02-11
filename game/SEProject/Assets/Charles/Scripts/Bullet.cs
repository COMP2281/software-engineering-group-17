using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

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
           player.GetComponent<Lives>().heart_num--; 
           Debug.Log(player.GetComponent<Lives>().heart_num);
           Destroy(gameObject);
        }

        GameObject collide = GameObject.FindGameObjectWithTag("Collide");

        if (other.gameObject == collide)
        {
            Destroy(gameObject);
        }
    }

}
