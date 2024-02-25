using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S_Timer2 : MonoBehaviour
{
    public S_player_movement_2 player;

    public float targetTime = 60.0f;

    private bool startTimer = false;

    public Text timeText;

    public BoxCollider2D box;
    public AudioSource escapeMusic;
    public AudioSource oldMusic;
    // private AudioSource finishedMusic;

    public bool stoptimer = false;

    private bool overflowstopper = true;

    private bool overflowstopper2 = true;
    private bool hasStarted = false;

    private void Start()
    {
    }
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
                // oldMusic.Stop(); 
                if (overflowstopper2)
                {
                    overflowstopper2 = false;
                }
                targetTime -= Time.deltaTime;
                updateTimer(targetTime);
                if (targetTime <= 0.0f)
                {
                    targetTime = 0.0f;
                    if(overflowstopper)
                    {
                        overflowstopper = false;
                        timerEnded();
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
    
    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    void timerEnded()
    {
        player.canmove = false;
        player.canmove = false;
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
        escapeMusic.Stop();
        // escapeMusic.Play();
        yield return new WaitForSeconds(3);
    }
}

