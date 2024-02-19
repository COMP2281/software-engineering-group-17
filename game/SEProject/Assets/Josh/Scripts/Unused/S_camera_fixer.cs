using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_camera_fixer : MonoBehaviour
{
    public BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            Debug.Log("gotem");
            box.enabled = false;
        }
    }
}
