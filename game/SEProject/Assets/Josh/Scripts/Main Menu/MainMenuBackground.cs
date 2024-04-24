using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBackground : MonoBehaviour
{
    public Material blur;
    private int randomNumber;
    private float range = 0;
    private bool changeRange = false;
    private float amount = 0.01f;

    private bool canRoll = true;

    private Animator anim;
  
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canRoll)
        {
            canRoll = false;
            randomNumber = Random.Range(0, 10);
            StartCoroutine(Pause());
        }

        if (randomNumber == 0)
        {
            changeRange = true;
        }
        else if (randomNumber == 1 || randomNumber == 2 || randomNumber == 3 || randomNumber == 4)
        {
            anim.enabled = true;
            changeRange = false;
        }
        else if (randomNumber == 5 || randomNumber == 6 || randomNumber == 7)
        {
            anim.enabled = true;
            changeRange = true;
        }
        else
        {
            changeRange = false;
            anim.enabled = false;
        }
        if(changeRange)
        {
            range += amount;
            if(range >= 2)
            {
                range = 2;
            }
            
        }
        else
        {
            range -= amount;
            if (range <= 0)
            {
                range = 0;
            }
        }
        blur.SetFloat("_Size", range);

    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(4);
        canRoll = true;
    }
}
