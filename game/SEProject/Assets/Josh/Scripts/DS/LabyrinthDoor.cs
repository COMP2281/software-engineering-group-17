using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class LabyrinthDoor : MonoBehaviour
{
    public static LabyrinthDoor labyrinthDoor;

    public string[] doors = new string[10];
    public BoxCollider2D left_door;
    public BoxCollider2D right_door;
    public BoxCollider2D top_door;

    public int number_of_doors;

    public string was_hit = "none";

    private int counter = 0;

    public bool finished = false;

    public AudioSource correct_answer;
    public AudioSource wrong_answer;

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag.Equals("Player"))
        {
            if (doors[counter] == was_hit)
            {
                counter++;
                if(!finished)
                {
                    correct_answer.Play();
                }
            }
            else
            {
                counter = 0;
                if (!finished)
                {
                    wrong_answer.Play();
                }
            }

            if (counter >= number_of_doors)
            {
                
                finished = true;
                counter = 0;
            }
                was_hit = "none";
        }
    }
   
}
