using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_teleporter : MonoBehaviour
{
    public GameObject player;
    public GameObject spawn;
    public GameObject hole;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            player.transform.position = spawn.transform.position;
            hole.SetActive(false);
        }
    }
}
