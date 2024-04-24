using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
           other.gameObject.GetComponent<PlayerMovement2>().moveSpeed = 10; 
           Destroy(gameObject);
        }
    }
}
