using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIWorldFollowCamera : MonoBehaviour
{
    private bool followPlayer = false;
    private GameObject player;
    private float x;
    private float y;
    private void Start() {
        x = transform.position.x;
        y = transform.position.y;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update() {
        if (followPlayer) {
            x = player.transform.position.x;
            y = player.transform.position.y;
            Debug.Log(x);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Player")) {
            followPlayer = true;
            Debug.Log("Following");
            gameObject.GetComponent<Camera>().enabled = true;
        }
    } 
}
