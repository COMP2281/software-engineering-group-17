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

    public static int itemCount = 0;

    private bool enableParticles;

    private float volume;

    public AudioMixer mastervol;

    private int graphics;

    private const string HUB_WORLD_NAME = "Hub World New";
    private const string DS_WORLD_NAME = "DS World Boss";
    private const string MAIN_MENU_WORLD = "Main Menu";

    private string CurrentScene() {
        return SceneManager.GetActiveScene().name;
    }

    // Start is called before the first frame update
    void Start()
    {
        if(CurrentScene() == HUB_WORLD_NAME || CurrentScene() == DS_WORLD_NAME)
        {
            Destroy(MusicManager.instance.gameObject);
        }
    }
    private void Update()
    {
        if (CurrentScene() == MAIN_MENU_WORLD) return;
        PlayerPrefs.SetString("last-scene", CurrentScene());
    }

    private void Awake()
    {

        if (gmInstance == null)
        {
            gmInstance = this;
            DontDestroyOnLoad(gameObject);
            
        }
    }


    public void NewGame()
    {
        SceneManager.LoadScene(HUB_WORLD_NAME);
    }

    public void LoadFromSave() {
        SceneManager.LoadScene(PlayerPrefs.GetString("last-scene", HUB_WORLD_NAME));
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
        PlayerPrefs.SetFloat("volume", volume);
    }

    public int GetGraphics()
    {
        return graphics;
    }

    public void SetGraphics(int g)
    {
        graphics = g;
        QualitySettings.SetQualityLevel(graphics);
    }

}
