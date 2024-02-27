using UnityEngine;

public class AIPortal : MonoBehaviour
{
    public int index;
    private GameObject player;
    private GameObject parent;
    void Start() {
        parent = transform.parent.gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
    }

   void OnTriggerEnter2D(Collider2D other) {
        GameObject nextPortal;
        if (!parent.GetComponent<PortalParent>().onCooldown && other.gameObject == player) {
            nextPortal = parent.GetComponent<PortalParent>().GetNextPortal(index); 
            player.transform.position = nextPortal.transform.position;
        }
   } 
}
