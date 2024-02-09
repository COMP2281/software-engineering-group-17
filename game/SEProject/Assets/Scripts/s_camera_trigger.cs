using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_camera_trigger : MonoBehaviour
{
    public Camera camera;
    public string move_direction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag.Equals("Player"))
        {
            if (move_direction == "right")
            {
                camera.transform.position += camera.transform.right * 5f;
            }
        }
    }
}
