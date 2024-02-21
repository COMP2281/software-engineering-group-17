using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static GM gmInstance;
    public bool hasItem1;
    public bool hasItem2;
    public bool hasItem3;  
    public bool hasItem4;

    public static int itemCount = 4;

    private bool enableParticles;

    private float volume;

    public AudioMixer mastervol;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Hub World New")
        {
            Destroy(MusicManager.instance.gameObject);
        }
    }
    private void Update()
    {
        Debug.Log(enableParticles);
    }

    private void Awake()
    {

        if (gmInstance == null)
        {
            gmInstance = this;
            DontDestroyOnLoad(gameObject);
            
        }
    }

    public bool GetParticle()
    {
        return enableParticles;
    }

    public void SetParticle(bool ep)
    {
        enableParticles = ep;
    }

    public float GetVolume()
    {
        return volume;
    }

    public void SetVolume(float v)
    {
        volume = v;
        mastervol.SetFloat("volume", volume);
    }

}
