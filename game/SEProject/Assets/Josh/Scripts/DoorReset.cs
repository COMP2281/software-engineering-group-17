using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorReset : MonoBehaviour
{
    public LabyrinthDoor door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("player"))
        {
           door.finished = false;
            door.was_hit = "";
            
          
        }
    }
}
