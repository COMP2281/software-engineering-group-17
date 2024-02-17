using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class S_hub_door : MonoBehaviour
{
    private bool can_open_door;
    public SpriteRenderer door_sprite;

    public Sprite door_open;
    public Sprite door_close;

    public BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(can_open_door && Input.GetKeyDown(KeyCode.Space))
        {
            door_sprite.sprite = door_open;
            box.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            can_open_door = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            can_open_door = false;
            door_sprite.sprite = door_close;
            box.enabled = true;
        }
    }
}
