using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeButton : MonoBehaviour
{
    public GameObject Key_Manager;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
        if (other.gameObject == player)
        {
            Key_Manager.GetComponent<AddEscape>().escapeStart = true;
            Destroy(gameObject);
        }
    }
}
