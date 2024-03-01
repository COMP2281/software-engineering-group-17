using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreBattleCutscene : MonoBehaviour
{
    public List<GameObject> dialogueBoxes;

    private bool startConvo = false;

    private int dialogueCounter;

    public PlayerScript player;

    public string sceneName;

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
                player.canMove = true;
                startConvo = false;
                SceneManager.LoadScene(sceneName);
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
