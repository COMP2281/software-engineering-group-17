using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_camera_follow : MonoBehaviour
{
    public GameObject cameras;
    public GameObject followcam;
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
        if (collision.tag.Equals("Player"))
        {
            followcam.SetActive(true);
            cameras.SetActive(false);
        }
    }
}
