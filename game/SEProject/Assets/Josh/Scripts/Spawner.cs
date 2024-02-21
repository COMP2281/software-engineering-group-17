using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public PlayerScript player;

    public GameObject respawner;
    public GameObject respawner2;

    private bool isMoving = false;

    public LabyrinthDoor labyrinthDoor;

    public Camera camera1;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera2.enabled = false;
    }

    private void Update()
    {
        if(labyrinthDoor.finished)
        {
            respawner = respawner2;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(isMoving)
        {
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            if (labyrinthDoor.finished)
            {
                Debug.Log("does the thing");
                player.canMove = false;
                player.transform.position = respawner2.transform.position;
                isMoving = true;
                player.anim.SetTrigger("auto move");
                player.anim.SetBool("can move", false);
                
                camera1.enabled = false;
                camera2.enabled = true;
                StartCoroutine(move_player());
            }
            else
            {
                player.canMove = false;
                player.transform.position = respawner.transform.position;
                isMoving = true;
                player.anim.SetTrigger("auto move");
                player.anim.SetBool("can move", false);
                
                StartCoroutine(move_player());
            }

        }
    }

    IEnumerator move_player()
    {
        yield return new WaitForSeconds(0.7f);
        isMoving = false;
        player.canMove = true;
        player.anim.SetBool("can move", true);
    }
}
