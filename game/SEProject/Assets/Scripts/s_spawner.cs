using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_spawner : MonoBehaviour
{
    public S_player_movement player;

    public GameObject respawner;
    public GameObject respawner2;

    private bool is_moving = false;

    public S_labyrinth_door s_Labyrinth_Door;

    public Camera camera1;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera2.enabled = false;
    }

    private void Update()
    {
        if(s_Labyrinth_Door.finished)
        {
            respawner = respawner2;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(is_moving)
        {
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            if (s_Labyrinth_Door.finished)
            {
                Debug.Log("does the thing");
                player.canmove = false;
                player.transform.position = respawner2.transform.position;
                is_moving = true;
                player.anim.SetTrigger("auto move");
                player.anim.SetBool("can move", false);
                
                camera1.enabled = false;
                camera2.enabled = true;
                StartCoroutine(move_player());
            }
            else
            {
                player.canmove = false;
                player.transform.position = respawner.transform.position;
                is_moving = true;
                player.anim.SetTrigger("auto move");
                player.anim.SetBool("can move", false);
                
                StartCoroutine(move_player());
            }
                
            
            

        }
    }

    IEnumerator move_player()
    {
        //player.anim.applyRootMotion = true;
        //player.anim.SetBool("spawn", true);
        
        yield return new WaitForSeconds(0.7f);
        //player.anim.applyRootMotion = false;
        //player.anim.SetBool("spawn", false);
        is_moving = false;
        player.canmove = true;
        player.anim.SetBool("can move", true);
    }
}
