using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldItem : MonoBehaviour
{
    public GameObject shield;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            shield.GetComponent<Shield>().canShield = true;
            shield.GetComponent<Shield>().shieldBarObject.SetActive(true);
            Destroy(gameObject);    
        }
    }
}
