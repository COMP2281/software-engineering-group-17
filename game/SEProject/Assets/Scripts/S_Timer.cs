using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S_Timer : MonoBehaviour
{
    public S_player_movement player;

    public float targetTime = 60.0f;

    public AudioSource _audioSource;

    public AudioSource yay;

    public AudioSource musicSource;

    private bool startTimer = false;

    public Text timeText;

    public BoxCollider2D box;

    public bool stoptimer = false;

    private bool overflowstopper = true;

    private bool overflowstopper2 = true;

    
    private void Start()
    {
        //_audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        
        if (!stoptimer)
        {
            if (startTimer)
            {
                S_musicmanager.instance.StopMusic();
                //manager.instance.StopMusic();
                if (overflowstopper2)
                {
                    overflowstopper2 = false;
                    musicSource.Play();
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
                musicSource.Stop();
                
                yay.Play();
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
       
        _audioSource.Play();
        player.canmove = false;
        StartCoroutine(Restart());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            startTimer = true;
            box.enabled = false;
            Debug.Log("start");
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
        S_musicmanager.instance.PlayMusic();
    }
}

