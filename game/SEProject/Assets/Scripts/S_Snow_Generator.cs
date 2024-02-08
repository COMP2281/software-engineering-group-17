using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Snow_Generator : MonoBehaviour
{
    public List<GameObject> objectsToCheck;

    public GameObject snowGen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach (GameObject obj in objectsToCheck)
        {
            Camera cam = obj.GetComponent<Camera>();
            if (cam.enabled)
            {   
                snowGen.transform.position = new Vector2(cam.transform.position.x, cam.transform.position.y+5);
                //Debug.Log(obj.name + " contains a Camera component.");
                // Optionally, do something with 'cam' or 'obj' here
            }
        }

        
    }
}
