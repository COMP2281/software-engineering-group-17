using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableArrow : MonoBehaviour
{
    public GameObject arrow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            arrow.SetActive(true);
        }
    }
}
