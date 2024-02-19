using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_name_player : MonoBehaviour
{
    public Text t;
    
    
    // Start is called before the first frame update
    void Start()
    {
        t.text = System.Environment.UserName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
