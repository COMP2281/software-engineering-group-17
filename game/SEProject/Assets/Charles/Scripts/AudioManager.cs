using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource backgroundMusic;

    private void OnTriggerEnter2D(Collider2D other) {
        if (!backgroundMusic.isPlaying && other.tag.Equals("Player")){
            backgroundMusic.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag.Equals("Player")){
            Debug.Log(gameObject.transform.position.x);
            backgroundMusic.Stop();
        }
    }
}