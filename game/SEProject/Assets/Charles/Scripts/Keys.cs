using UnityEngine;

public class Keys : MonoBehaviour
{
    public GameObject keyManager;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
        if (other.gameObject == player)
        {
            keyManager.GetComponent<KeyManager>().keyNum--;  
            Destroy(gameObject);
        }
    }
}
