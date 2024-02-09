using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_sign : MonoBehaviour
{
    public GameObject question_box;
    private bool in_range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && in_range)
        {
            //Debug.Log("works");
            if(question_box.activeInHierarchy)
            {
                question_box.SetActive(false);
            }
            else
            {
                question_box.SetActive(true);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            in_range = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            in_range = false;
            question_box.SetActive(false);
        }
    }
}
