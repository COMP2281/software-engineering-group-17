using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_background : MonoBehaviour
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
        //Debug.Log(anim.speed);
        if(canRoll)
        {
            canRoll = false;
            randomNumber = Random.Range(0, 10);
            StartCoroutine(Pause());
        }

        //Debug.Log(blur.HasProperty("Size"));

        if (randomNumber == 0)
        {
            changeRange = true;
        }
        else if (randomNumber == 1 || randomNumber == 2 || randomNumber == 3)
        {
            anim.enabled = true;
            //anim.speed = 1;
            changeRange = false;
        }
        else if (randomNumber == 4 || randomNumber == 5 || randomNumber == 6)
        {
            anim.enabled = true;
            changeRange = true;
        }
        else
        {
            changeRange = false;
            anim.enabled = false;
            //anim.speed = 0;
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
        yield return new WaitForSeconds(3);
        canRoll = true;
    }
}
