using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    public PlayerMovement2 player;
    public GameObject[] previousMusic;
    public int previousMusicNum;
    public float targetTime = 60.0f;

    private bool startTimer = false;

    public Text timeText;

    public BoxCollider2D box;
    public AudioSource escapeMusic;

    public bool stoptimer = false;

    private bool overflowstopper = true;

    private bool overflowstopper2 = true;
    private bool hasStarted = false;
    
    void Update()
    {
        if (!stoptimer)
        {
            if (startTimer)
            {
                if (!hasStarted) {
                    escapeMusic.Play();
                    hasStarted = true;
                }

                if (overflowstopper2)
                {
                    overflowstopper2 = false;
                }

                targetTime -= Time.deltaTime;
                UpdateTimer(targetTime);

                if (targetTime <= 0.0f)
                {
                    targetTime = 0.0f;
                    if(overflowstopper)
                    {
                        overflowstopper = false;
                        TimerEnded();
                    }
                    
                }
            }
        }
        else
        {
           
            
            if(overflowstopper)
            {
                overflowstopper = false;
                
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
        player.canMove = false;
        StartCoroutine(Restart());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            for (int i = 0; i < previousMusicNum; i++) {
                previousMusic[i].SetActive(false);
            }
            startTimer = true;
            timeText.enabled = true;
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
        escapeMusic.Stop();
        // escapeMusic.Play();
        yield return new WaitForSeconds(3);
    }
}

