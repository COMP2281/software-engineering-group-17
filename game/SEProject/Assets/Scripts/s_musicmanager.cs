using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_musicmanager : MonoBehaviour
{   
    public static S_musicmanager instance;

    private AudioSource _audioSource;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            _audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        //PlayMusic();
    }
    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    
}
