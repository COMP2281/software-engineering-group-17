using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarCutscene2 : MonoBehaviour
{
    public List<GameObject> dialogueBoxes;

    private bool startConvo = false;

    private int dialogueCounter;

    public PlayerScript player;

    public bool cutsceneDone = false;

    private BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }

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
                cutsceneDone = true;
                box.enabled = false;
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
