using UnityEngine;

public class EscapeButton : MonoBehaviour
{
    public GameObject keyManager;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); 
        if (other.gameObject == player)
        {
            keyManager.GetComponent<AddEscape>().escapeStart = true;
            Destroy(gameObject);
        }
    }
}
