using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerRight : MonoBehaviour
{
    public LabyrinthDoor s_Labyrinth_Door;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            s_Labyrinth_Door.was_hit = "right";

        }
    }
}