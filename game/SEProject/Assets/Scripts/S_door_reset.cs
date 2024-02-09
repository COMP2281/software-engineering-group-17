using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_door_reset : MonoBehaviour
{
    public S_labyrinth_door door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("player"))
        {
           door.finished = false;
            door.was_hit = "";
            
          
        }
    }
}
