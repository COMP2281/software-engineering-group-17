using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public PlayerScript player;

    public float targetTime = 60.0f;

    public AudioSource _audioSource;

    public AudioSource yay;

    public AudioSource musicSource;

    private bool startTimer = false;

    public Text timeText;

    public BoxCollider2D box;

    public bool stoptimer = false;

    private bool overflowStopper = true;

    private bool overflowStopper2 = true;

    void Update()
    {
        if (!stoptimer)
        {
            if (startTimer)
            {
                MusicManager.instance.StopMusic();
                
                if (overflowStopper2)
                {
                    overflowStopper2 = false;
                    musicSource.Play();
                }
                targetTime -= Time.deltaTime;
                UpdateTimer(targetTime);
                if (targetTime <= 0.0f)
                {
                    targetTime = 0.0f;
                    if(overflowStopper)
                    {
                        overflowStopper = false;
                        TimerEnded();
                    }
                }
            }
        }
        else
        {
            if(overflowStopper)
            {
                overflowStopper = false;
                musicSource.Stop();
                
                yay.Play();
                StartCoroutine(PlayMusic());
            }
        }
    }
    
    void UpdateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    void TimerEnded()
    {
        player.canMove = false;
        _audioSource.Play();
        player.canMove = false;
        StartCoroutine(Restart());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            startTimer = true;
            box.enabled = false;
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator PlayMusic()
    {
        yield return new WaitForSeconds(3);
        MusicManager.instance.ChangeMusic();
        MusicManager.instance.PlayMusic();
    }
}

