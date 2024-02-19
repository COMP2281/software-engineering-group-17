using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TimerStop : MonoBehaviour
{
    
    public Timer timer;
    public BoxCollider2D box;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            timer.stoptimer = true;
            box.enabled = false;
        }
    }
}
