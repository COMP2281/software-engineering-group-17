using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;

    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (GM.gmInstance.GetItem1())
        {
            item1.SetActive(true);
        }
        if (GM.gmInstance.GetItem2())
        {
            item2.SetActive(true);
        }
        if (GM.gmInstance.GetItem3())
        {
            item3.SetActive(true);
        }
        if (GM.gmInstance.GetItem4())
        {
            item4.SetActive(true);
        }

        if(Input.anyKeyDown)
        {
            pauseMenu.SetActive(true);
            this.gameObject.SetActive(false);
        }
        
    }
}
