using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_camera_manager : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        //camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            camera.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            camera.enabled = false;
        }
    }
}
