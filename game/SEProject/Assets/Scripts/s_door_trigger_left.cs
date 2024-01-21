using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_door_trigger_left : MonoBehaviour
{

    public S_labyrinth_door s_Labyrinth_Door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            s_Labyrinth_Door.was_hit = "left";

        }
    }
}
