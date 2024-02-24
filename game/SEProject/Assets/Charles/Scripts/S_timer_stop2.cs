using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_timer_stop2 : MonoBehaviour
{
    
    public GameObject timer;
    public BoxCollider2D box;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            timer.GetComponent<S_Timer2>().stoptimer = true;
            box.enabled = false;
        }
    }
}
