using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreBattleCutsceneAI : MonoBehaviour
{
    public List<GameObject> dialogueBoxes;

    private bool startConvo = false;

    private int dialogueCounter;

    public GameObject player;

    public string sceneName;

    // Update is called once per frame
    void Update()
    {
        if (startConvo)
        {
            player.GetComponent<PlayerMovement2>().canMove = false;
            player.GetComponent<Dash>().canDash = false;
            dialogueBoxes[dialogueCounter].SetActive(true);
            if (Input.GetButtonDown("Fire1"))
            {
                dialogueBoxes[dialogueCounter].SetActive(false);
                dialogueCounter++;
            }

            if (dialogueCounter >= dialogueBoxes.Count)
            {
                player.GetComponent<PlayerMovement2>().canMove = true;
                player.GetComponent<Dash>().canDash = true;
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
