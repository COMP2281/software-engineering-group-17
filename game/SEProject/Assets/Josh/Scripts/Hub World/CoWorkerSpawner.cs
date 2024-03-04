using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoWorkerSpawner : MonoBehaviour
{
    public GameObject coWorker1;
    public GameObject coWorker2;
    //public GameObject coWorker3;
    //public GameObject coWorker4;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (GM.gmInstance.GetItem1())
        {
            coWorker1.SetActive(true);
        }
        if (GM.gmInstance.GetItem2())
        {
            coWorker2.SetActive(true);
        }
    }
}
