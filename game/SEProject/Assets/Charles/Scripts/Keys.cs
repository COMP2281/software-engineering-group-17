using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public GameObject Key_Manager;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
        if (other.gameObject == player)
        {
            Key_Manager.GetComponent<Key_Manager>().key_num--;  
            Destroy(gameObject);
        }
    }
}
