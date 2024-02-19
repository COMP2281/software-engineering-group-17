using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Destroy(MusicManager.instance.gameObject);
        }
        catch { 
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
