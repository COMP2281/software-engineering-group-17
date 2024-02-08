using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Button_spawner : MonoBehaviour
{
    public List<GameObject> spawnLocations;

    private bool canpress = false;

    public int hitcounter = 20;

    public GameObject button;

    private int randomNumber;

    public GameObject player;
    public GameObject spawn;
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 20);
        Spawn(randomNumber);
    }

    // Update is called once per frame
    void Update()
    {
        if (canpress && Input.GetKeyDown(KeyCode.Space))
        {
            hitcounter--;
            randomNumber = Random.Range(0, 10);
            Spawn(randomNumber);
        }
        if(hitcounter == 0)
        {
            player.transform.position = spawn.transform.position;
            arrow.SetActive(false);
        }
        
    }

    void Spawn(int numb)
    {
        button.transform.position = spawnLocations[numb].transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            canpress = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            canpress = false;
        }
    }
}
