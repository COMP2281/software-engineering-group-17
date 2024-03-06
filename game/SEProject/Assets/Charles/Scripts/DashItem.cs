using System.Collections;
using UnityEngine;

public class DashItem : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource backgroundMusic;
    private GameObject player;
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player"); //Or however you get your player object here
    }
    void Update(){
        if (audioSource.isPlaying) {
            backgroundMusic.Pause();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            StartCoroutine(PlayAudio());
        }
    }    

    IEnumerator PlayAudio(){
        audioSource.Play();

        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        player.GetComponent<PlayerMovement2>().canMove = false;

        yield return new WaitForSeconds(6.5f);

        player.GetComponent<Dash>().canDash = true;
        player.GetComponent<PlayerMovement2>().canMove = true;
        backgroundMusic.Play();
        gameObject.SetActive(false);
    }
}
