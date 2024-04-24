using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public GameObject question_box;
    private bool inRange;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && inRange)
        {
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
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            inRange = false;
            question_box.SetActive(false);
        }
    }
}
