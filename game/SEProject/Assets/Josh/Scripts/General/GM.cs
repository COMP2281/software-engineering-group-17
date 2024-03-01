using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static GM gmInstance;
    private bool hasItem1;
    private bool hasItem2;
    private bool hasItem3;  
    private bool hasItem4;

    private int itemCount = 0;

    private int attackDamage = 1;
    private int hP = 10;

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
        Debug.Log(itemCount);
    }

    private void Awake()
    {

        if (gmInstance == null)
        {
            gmInstance = this;
            DontDestroyOnLoad(gameObject);
            
        }
    }

    public int GetItemCount()
    {
        return itemCount;
    }

    public void AddItem()
    {
        itemCount += 1;
    }

    public void GotItem1()
    {
        hasItem1 = true;
    }

    public bool GetItem1()
    {
        return hasItem1;
    }

    public void GotItem2()
    {
        hasItem2 = true;
    }

    public bool GetItem2()
    {
        return hasItem2;
    }

    public void GotItem3()
    {
        hasItem3 = true;
    }

    public bool GetItem3()
    {
        return hasItem3;
    }

    public void GotItem4()
    {
        hasItem4 = true;
    }

    public bool GetItem4()
    {
        return hasItem4;
    }

    public int GetAttackDamage()
    {
        return attackDamage;
    }

    public void AddAttackDamage(int damage)
    {
        attackDamage += damage;
    }

    public int GetHP()
    {
        return hP;
    }

    public void AddHP(int hp)
    {
        hP += hp;
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
