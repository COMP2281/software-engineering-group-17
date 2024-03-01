using System.Collections;
using UnityEngine;

public class DashItem : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource backgroundMusic;

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
            player.GetComponent<Dash>().canDash = true;
            StartCoroutine(PlayAudio());
        }
    }    

    IEnumerator PlayAudio(){
        audioSource.Play();

        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(9.5f);

        backgroundMusic.Play();
        gameObject.SetActive(false);
    }
}
