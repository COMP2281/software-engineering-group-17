using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_into_cutscene : MonoBehaviour
{
    public List<GameObject> dialogueBoxes;

    private bool startconvo = false;

    private int dialogueCounter;

    public S_player_movement player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startconvo)
        {
            player.canmove = false;
            dialogueBoxes[dialogueCounter].SetActive(true);
            if(Input.GetButtonDown("Fire1")) 
            {
                dialogueBoxes[dialogueCounter].SetActive(false);
                dialogueCounter++;
            }

            if(dialogueCounter >= dialogueBoxes.Count)
            {
                player.canmove = true;
                startconvo = false;
                Destroy(this.gameObject);
            }
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
