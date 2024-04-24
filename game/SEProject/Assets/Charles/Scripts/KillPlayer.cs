using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
        if (other.gameObject == player)
        {
            if (!player.GetComponent<Dash>().isDashing) {
                player.GetComponent<Lives>().DamagePlayer(); 
            }
        }
    }
}