using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
        if (other.gameObject == player)
        {
            if (!player.GetComponent<Dash>().isDashing) {
                player.GetComponent<Lives>().heart_num--; 
            }
        }
    }
}