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

    private const int DEFAULT_ATTACK_DAMAGE = 2;
    private const int DEFAULT_HEALTH_POINTS = 10;

    private const bool DEFAULT_ENABLE_PARTICLES = true;

    // TODO: What is the default vlalue?
    private const int DEFAULT_GRAPHICS = 0;

    private string CurrentScene()
    {
        return SceneManager.GetActiveScene().name;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (CurrentScene() == HUB_WORLD_NAME || CurrentScene() == DS_WORLD_NAME)
        {
            if (MusicManager.instance != null)
                Destroy(MusicManager.instance.gameObject);
        }
    }
    private void Update()
    {
        if (CurrentScene() == MAIN_MENU_WORLD) return;
        PlayerPrefs.SetString("last-scene", CurrentScene());
    }

    [System.Serializable]
    public class GMException : System.Exception
    {
        public GMException() { }
        public GMException(string message) : base(message) { }
        public GMException(string message, System.Exception inner) : base(message, inner) { }
        protected GMException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    private static bool asBool(int value)
    {
        if (value == 0) return false;
        if (value == 1) return true;
        throw new GMException($"Expected boolean value to be either 0 or 1 but got {value} instead.");
    }

    private static int asInt(bool value)
    {
        return value ? 1 : 0;
    }

    private void Awake()
    {

        if (gmInstance == null)
        {
            gmInstance = this;
            DontDestroyOnLoad(gameObject);

        }

        itemCount = PlayerPrefs.GetInt("hasItem1") + PlayerPrefs.GetInt("hasItem2") + PlayerPrefs.GetInt("hasItem3") + PlayerPrefs.GetInt("hasItem4");
        hasItem1 = asBool(PlayerPrefs.GetInt("hasItem1", 0));
        hasItem2 = asBool(PlayerPrefs.GetInt("hasItem2", 0));
        hasItem3 = asBool(PlayerPrefs.GetInt("hasItem3", 0));
        hasItem4 = asBool(PlayerPrefs.GetInt("hasItem4", 0));

        attackDamage = PlayerPrefs.GetInt("attackDamage", DEFAULT_ATTACK_DAMAGE);
        hP = PlayerPrefs.GetInt("hP", DEFAULT_HEALTH_POINTS);
        enableParticles = asBool(PlayerPrefs.GetInt("enableParticles", asInt(DEFAULT_ENABLE_PARTICLES)));
        graphics = PlayerPrefs.GetInt("graphics", DEFAULT_GRAPHICS);
    }

    public int GetItemCount()
    {
        return asInt(hasItem1) + asInt(hasItem2) + asInt(hasItem3) + asInt(hasItem4);
    }

    public void AddItem()
    {
        // Does nothing
    }

    public void GotItem1()
    {
        hasItem1 = true;
        PlayerPrefs.SetInt("hasItem1", 1);
    }

    public bool GetItem1()
    {
        return hasItem1;
    }

    public void GotItem2()
    {
        hasItem2 = true;
        PlayerPrefs.SetInt("hasItem2", 1);
    }

    public bool GetItem2()
    {
        return hasItem2;
    }

    public void GotItem3()
    {
        hasItem3 = true;
        PlayerPrefs.SetInt("hasItem3", 1);
    }

    public bool GetItem3()
    {
        return hasItem3;
    }

    public void GotItem4()
    {
        hasItem4 = true;
        PlayerPrefs.SetInt("hasItem4", 1);
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
        PlayerPrefs.SetInt("attackDamage", damage);
    }

    public int GetHP()
    {
        PlayerPrefs.SetInt("hP", hP);
        return hP;
    }

    public void AddHP(int hp)
    {
        hP += hp;
    }


    public void NewGame()
    {
        resetSave();
        SceneManager.LoadScene(HUB_WORLD_NAME);
    }

    private void resetSave()
    {
        PlayerPrefs.SetInt("hasItem1", 0);
        PlayerPrefs.SetInt("hasItem2", 0);
        PlayerPrefs.SetInt("hasItem3", 0);
        PlayerPrefs.SetInt("hasItem4", 0);

        PlayerPrefs.SetInt("attackDamage", DEFAULT_ATTACK_DAMAGE);
        PlayerPrefs.SetInt("hP", DEFAULT_HEALTH_POINTS);
        PlayerPrefs.SetInt("enableParticles", asInt(DEFAULT_ENABLE_PARTICLES));
        PlayerPrefs.SetInt("graphics", DEFAULT_GRAPHICS);
    }

    public void LoadFromSave()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("last-scene", HUB_WORLD_NAME));
    }

    public bool GetParticle()
    {
        return enableParticles;
    }

    public void SetParticle(bool ep)
    {
        enableParticles = ep;
        PlayerPrefs.SetInt("enableParticles", asInt(ep));
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
        PlayerPrefs.SetInt("graphics", g);
    }

}
