using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCutscene : MonoBehaviour
{
    public List<GameObject> dialogueBoxes;

    private bool startConvo = false;

    private int dialogueCounter;

    public PlayerScript player;
    

    // Update is called once per frame
    void Update()
    {
        if(startConvo)
        {
            player.canMove = false;
            dialogueBoxes[dialogueCounter].SetActive(true);
            if(Input.GetButtonDown("Fire1")) 
            {
                dialogueBoxes[dialogueCounter].SetActive(false);
                dialogueCounter++;
            }

            if(dialogueCounter >= dialogueBoxes.Count)
            {
                player.canMove = true;
                startConvo = false;
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            startConvo = true;
        }
    }
}
