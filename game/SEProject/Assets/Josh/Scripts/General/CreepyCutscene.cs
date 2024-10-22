using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyCutscene : MonoBehaviour
{
    public List<GameObject> dialogueBoxes;

    private int dialogueCounter;
    

    // Update is called once per frame
    void Update()
    {
        dialogueBoxes[dialogueCounter].SetActive(true);
        if (Input.GetButtonDown("Fire1"))
        {
            dialogueBoxes[dialogueCounter].SetActive(false);
            dialogueCounter++;
        }

        if (dialogueCounter >= dialogueBoxes.Count)
        {
            Application.OpenURL("https://static.wikia.nocookie.net/doki-doki-literature-club/images/a/a6/Monika_scare.png/revision/latest?cb=20171203130936");
            Application.Quit();
        }
    }
}
