using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HubDoor : MonoBehaviour
{
    private bool canOpenDoor;
    public SpriteRenderer door_sprite;

    public Sprite door_open;
    public Sprite door_close;

    public BoxCollider2D box;


    // Update is called once per frame
    void Update()
    {
        if(canOpenDoor && Input.GetKeyDown(KeyCode.Space))
        {
            door_sprite.sprite = door_open;
            box.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            canOpenDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            canOpenDoor = false;
            door_sprite.sprite = door_close;
            box.enabled = true;
        }
    }
}
