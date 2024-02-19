using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_alter_cutscene : MonoBehaviour
{
    public S_alter_cutscene_2 alter;

    private bool startconvo = false;

    public GameObject dialogueBox;

    public S_player_movement player;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startconvo)
        {
            dialogueBox.SetActive(true);
            player.canmove = false;
            if (Input.GetButtonDown("Fire1"))
            {
                dialogueBox.SetActive(false);
                startconvo = false;
                player.canmove = true;
            }
        }
        if(alter.cutsceneDone)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            startconvo = true;
        }
    }
}
