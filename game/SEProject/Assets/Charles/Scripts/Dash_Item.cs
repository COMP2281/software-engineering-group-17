using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash_Item : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject camera1;
    private AudioSource backgroundMusic;
    void Start(){
        backgroundMusic = camera1.GetComponent<AudioSource>();
    }
    void Update(){
        if (audioSource.isPlaying) {
            backgroundMusic.Pause();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
        if (other.gameObject == player)
        {
            StartCoroutine(playAudio(player));
        }
    }    
    IEnumerator playAudio(GameObject player){

        player.GetComponent<Dash>().canDash = true;

        audioSource.Play();

        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(9.5f);

        backgroundMusic.Play();
        gameObject.SetActive(false);
    }
}
