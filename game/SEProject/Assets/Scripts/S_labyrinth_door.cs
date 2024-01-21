using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.UIElements;

public class S_labyrinth_door : MonoBehaviour
{
    public static S_labyrinth_door s_Labyrinth_Door;

    public string[] doors = new string[10];
    public BoxCollider2D left_door;
    public BoxCollider2D right_door;
    public BoxCollider2D top_door;

    public int number_of_doors;

    public string was_hit = "none";

    private int counter = 0;

    public bool finished = false;

    public Camera camera1;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera2.enabled = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag.Equals("Player"))
        {
            //StartCoroutine(Checkhit());
            if (doors[counter] == was_hit)
            {
                counter++;
                Debug.Log(counter);
            }
            else
            {
                counter = 0;
                Debug.Log(counter);
            }

            if (counter == number_of_doors-1)
            {
                finished = true;
                Debug.Log("done");
            }
            else if (counter == number_of_doors)
            {
                camera1.enabled = false;
                camera2.enabled = true;
                
            }

                was_hit = "none";

        }
    }
    /*
    IEnumerator Checkhit()
    {

        /*
        if (was_hit == "left") {
            Debug.Log("left one");
        }
        else if (was_hit == "right") 
        {
            Debug.Log("right one");
        }
        else if (was_hit == "top")
        {
            Debug.Log("top one");
        }
        

        

    }
    */
}
