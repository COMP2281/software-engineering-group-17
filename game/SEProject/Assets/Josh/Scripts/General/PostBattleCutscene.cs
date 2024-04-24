using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostBattleCutscene : MonoBehaviour
{
    public List<GameObject> dialogueBoxes;

    private bool startConvo = false;

    private int dialogueCounter;

    public PlayerScript player;

    public GameObject coWorker;

    public GameObject powerUp;

    // Update is called once per frame
    void Update()
    {
        if (startConvo)
        {
            player.canMove = false;
            dialogueBoxes[dialogueCounter].SetActive(true);
            if (Input.GetButtonDown("Fire1"))
            {
                dialogueBoxes[dialogueCounter].SetActive(false);
                dialogueCounter++;
            }

            if (dialogueCounter >= dialogueBoxes.Count)
            {
                startConvo = false;
                powerUp.SetActive(true);
                coWorker.SetActive(false);


                if(SceneManager.GetActiveScene().name == "DS World Boss Complete")
                {
                    GM.gmInstance.GotItem1();
                }
                else if(SceneManager.GetActiveScene().name == "AI-World-Complete")
                {
                    GM.gmInstance.GotItem2();
                }

                
                dialogueCounter = 0;
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
