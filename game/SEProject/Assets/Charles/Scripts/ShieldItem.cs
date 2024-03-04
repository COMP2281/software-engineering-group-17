using UnityEngine;
using System.Collections;

public class ShieldItem : MonoBehaviour
{
    public GameObject shield;
    private AudioSource audioSource;
    public AudioSource backgroundMusic;
    private GameObject player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    
    void Update(){
        if (audioSource.isPlaying) {
            backgroundMusic.Pause();
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            shield.GetComponent<Shield>().shieldBarObject.SetActive(true);
            StartCoroutine(PlayAudio());
        }
    }
    IEnumerator PlayAudio(){
        audioSource.Play();

        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        player.GetComponent<PlayerMovement2>().canMove = false;
        player.GetComponent<Dash>().canDash = false;

        yield return new WaitForSeconds(9.5f);

        shield.GetComponent<Shield>().canShield = true;
        player.GetComponent<Dash>().canDash = true;
        player.GetComponent<PlayerMovement2>().canMove = true;
        backgroundMusic.Play();
        gameObject.SetActive(false);
    }
}
