using UnityEngine;

public class TimerStop2 : MonoBehaviour
{
    
    public GameObject timer;
    public BoxCollider2D box;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            timer.GetComponent<Timer2>().stoptimer = true;
            box.enabled = false;
        }
    }
}
