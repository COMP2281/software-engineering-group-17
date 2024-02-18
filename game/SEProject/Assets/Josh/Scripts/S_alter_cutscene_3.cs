using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class S_alter_cutscene_3 : MonoBehaviour
{
    public S_alter_cutscene_2 alter;

    private bool startconvo = false;

    public List<GameObject> dialogueBoxes;

    public S_player_movement player;

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

        if (startconvo)
        {
            player.canmove = false;
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
