using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_remove_arrow : MonoBehaviour
{
    public GameObject arrow;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(arrow);
            Destroy(this.gameObject);
        }
    }
}

