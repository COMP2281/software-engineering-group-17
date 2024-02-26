using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubDoorTrigger : MonoBehaviour
{
    public GameObject movePoint;

    public GameObject currentCam;
    public GameObject enableCam;
    public GameObject disableCam1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.transform.position = movePoint.transform.position;
            currentCam.SetActive(false);
            enableCam.SetActive(true); 
            disableCam1.SetActive(false);
        }
    }
}
