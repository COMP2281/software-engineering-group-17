using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_wall_maker : MonoBehaviour
{
   
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
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
