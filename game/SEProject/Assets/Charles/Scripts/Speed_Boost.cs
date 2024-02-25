using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Boost : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
           other.gameObject.GetComponent<S_player_movement_2>().moveSpeed = 10; 
           Destroy(gameObject);
        }
    }
}
