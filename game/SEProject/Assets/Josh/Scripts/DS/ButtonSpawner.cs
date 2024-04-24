using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSpawner : MonoBehaviour
{
    public List<GameObject> spawnLocations;

    private bool canPress = false;

    public int hitCounter = 20;

    public GameObject button;

    private int randomNumber;

    public GameObject player;
    public GameObject spawn;
    public GameObject arrow;

    public PlayerIceScript playerScript;

    private bool overloadStopper = true;

    public Text counterText;

    private int prevNumb = 0;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 20);
        Spawn(randomNumber);
    }

    // Update is called once per frame
    void Update()
    {
        if (canPress && Input.GetButtonDown("Fire1"))
        {
            hitCounter--;
         
            if (hitCounter != 0)
            {
                randomNumber = Random.Range(0, 20);
                while (prevNumb == randomNumber)
                {
                    randomNumber = Random.Range(0, 20);
                }
                Spawn(randomNumber);
            }
        }
        if(hitCounter == 0)
        {
            if (overloadStopper)
            {
                overloadStopper = false;
                player.transform.position = spawn.transform.position;
                arrow.SetActive(false);

            }
        }
        counterText.text = hitCounter.ToString();

        if (Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Spawn(int numb)
    {
        prevNumb = numb;
        button.transform.position = spawnLocations[numb].transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            canPress = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            canPress = false;
        }
    }

   
}
