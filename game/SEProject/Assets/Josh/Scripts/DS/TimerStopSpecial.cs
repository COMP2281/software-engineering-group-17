using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStopSpecial : MonoBehaviour
{
    public SpecialTime timer;
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
