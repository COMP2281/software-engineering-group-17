using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class MainMenuButtons : MonoBehaviour
{
    public AudioMixer mix;

    public GameObject optionsOutButton;
    public GameObject optionsInButton;

    public GameObject optionsMenu;
    public GameObject mainMenu;

    public Toggle particles;
    public Slider slider;
    public TMPro.TMP_Dropdown graphicsDropdown;
    public Toggle particlesToggle;
    private bool initialisedVolume;
    private bool initialisedGraphics;
    private bool initialisedParticles;
    private const string HUB_WORLD_NAME = "Hub World New";
    private void Start()
    {
        Particles(particles);
    }

    void loadVolumeSettings()
    {
        if (initialisedVolume) return;
        if (mix == null) return;
        if (GM.gmInstance == null) return;
        float value = PlayerPrefs.GetFloat("volume", 0);
        GM.gmInstance.SetVolume(value);
        try
        {
            slider = GameObject.FindWithTag("volume").GetComponent<Slider>();
        }
        catch
        {
            return;
        }
        slider.value = value;
        initialisedVolume = true;
    }

    void loadQualitySettings()
    {
        if (initialisedGraphics) return;
        if (GM.gmInstance == null) return;
        try {
            graphicsDropdown = GameObject.FindWithTag("graphics").GetComponent<TMP_Dropdown>();
        }
        catch {
            return;
        }
        graphicsDropdown.value = GM.gmInstance.GetGraphics();
        initialisedGraphics = true;
    }

    void loadParticleSettings() {
        if (initialisedParticles) return;
        if (GM.gmInstance == null) return;
        try {
            particlesToggle = GameObject.FindWithTag("particles").GetComponent<Toggle>();
        }
        catch {
            return;
        }
        particlesToggle.isOn = GM.gmInstance.GetParticle();
        initialisedParticles = true;
    }

    void Update()
    {
        loadVolumeSettings();
        loadQualitySettings();
        loadParticleSettings();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Volume(float volume)
    {
        if (!initialisedVolume) return;
        GM.gmInstance.SetVolume(volume);
    }

    public void Particles(bool disable_particles)
    {
        if (!initialisedParticles) return;
        GM.gmInstance.SetParticle(disable_particles);
    }

    public void FullScreen(bool isFS)
    {
        Screen.fullScreen = isFS;
    }

    public void MainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsOutButton);
    }

    public void OptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsInButton);
    }

    public void SetQuality(int quality)
    {
        if (!initialisedGraphics) return;
        GM.gmInstance.SetGraphics(quality);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
