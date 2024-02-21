using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Boost : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
        if (other.gameObject == player)
        {
           player.GetComponent<S_player_movement_2>().moveSpeed = 10; 
           Debug.Log(player.GetComponent<S_player_movement_2>().moveSpeed);
           Destroy(gameObject);
        }
    }
}
