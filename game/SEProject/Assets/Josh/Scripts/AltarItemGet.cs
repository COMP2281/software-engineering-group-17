using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarItemGet : MonoBehaviour
{
    public AltarCutscene4 alter;

    private bool startConvo = false;

    public GameObject dialogueBox;

    public PlayerScript player;




    // Update is called once per frame
    void Update()
    {
        if (startConvo)
        {
            dialogueBox.SetActive(true);
            player.canMove = false;
            if (Input.GetButtonDown("Fire1"))
            {
                dialogueBox.SetActive(false);
                startConvo = false;
                player.canMove = true;
            }
        }
        if (alter.cutsceneDone)
        {
            Destroy(this.gameObject);
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
