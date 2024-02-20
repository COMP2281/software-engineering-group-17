using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class GM : MonoBehaviour
{
    public static GM gmInstance;
    public bool hasItem1;
    public bool hasItem2;
    public bool hasItem3;  
    public bool hasItem4;

    public static int itemCount = 4;

   

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

}
