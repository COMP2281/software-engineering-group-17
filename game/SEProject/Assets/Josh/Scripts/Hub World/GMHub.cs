using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class GMHub : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    public GameObject entry1;
    public GameObject entry2;
    public GameObject entry3;
    public GameObject entry4;
    public GameObject entry5;

    
    public GameObject cloudMagicCircle;
    public GameObject aIMagicCircle;
    // Start is called before the first frame update
    void Start()
    {
        /*
        if (GM.gmInstance.hasItem1)
        {
            cloudMagicCircle.GetComponent<HubBackground>().enabled = false;
            cloudMagicCircle.GetComponent<CircleCollider2D>().enabled = false;
        }
        if (GM.gmInstance.hasItem2)
        {
            aIMagicCircle.GetComponent<HubBackground>().enabled = false;
            aIMagicCircle.GetComponent<CircleCollider2D>().enabled = false;
        }
        */
        if (GM.itemCount == 0)
        {
            entry1.SetActive(true);
        }
        else if (GM.itemCount == 1)
        {
            entry2.SetActive(true);
        }
        else if (GM.itemCount == 2)
        {
            entry3.SetActive(true);
        }
        else if (GM.itemCount == 3)
        {
            entry4.SetActive(true);
        }
        else if (GM.itemCount == 4)
        {
            entry5.SetActive(true);
        }
    }

}
