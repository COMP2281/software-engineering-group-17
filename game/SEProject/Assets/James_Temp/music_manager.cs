using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_manager : MonoBehaviour
{
    public static music_manager instance;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource.Play();
    }

    public void StopTheTunes()
    {
        _audioSource.Stop();
    }


}
