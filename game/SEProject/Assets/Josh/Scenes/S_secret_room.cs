using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_secret_room : MonoBehaviour
{
    public BoxCollider2D box;

    public GameObject secret_room;

    private bool canhit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (canhit)
            {
                box.enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            canhit = true;
            secret_room.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            box.enabled = true;
            secret_room.SetActive(false);
            canhit = false;
        }
    }
}
