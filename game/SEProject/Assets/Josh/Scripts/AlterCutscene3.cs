using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AlterCutscene3 : MonoBehaviour
{
    public AlterCutscene2 alter;

    private bool startConvo = false;

    public List<GameObject> dialogueBoxes;

    public PlayerScript player;

    private int dialogueCounter;

    public GameObject arrow;

    private BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(alter.cutsceneDone)
        {
            box.enabled = true;
        }

        if (startConvo)
        {
            player.canMove = false;
            dialogueBoxes[dialogueCounter].SetActive(true);
            if (Input.GetButtonDown("Fire1"))
            {
                dialogueBoxes[dialogueCounter].SetActive(false);
                dialogueCounter++;
            }
            if(dialogueCounter == 6) { 
                arrow.SetActive(true);
            }

            if (dialogueCounter >= dialogueBoxes.Count)
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
