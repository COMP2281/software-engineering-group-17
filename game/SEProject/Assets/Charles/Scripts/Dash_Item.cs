using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash_Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
        if (other.gameObject == player)
        {
           player.GetComponent<Dash>().canDash = true;
           Destroy(gameObject); 
        }
    }    
}
