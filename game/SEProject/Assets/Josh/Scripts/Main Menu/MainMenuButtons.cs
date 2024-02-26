using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public AudioMixer mix;

    public GameObject optionsOutButton;
    public GameObject optionsInButton;

    public GameObject optionsMenu;
    public GameObject mainMenu;

    public Toggle particles;
    public Slider slider;
    private bool alreadyInitialised;
    private void Start()
    {
        Particles(particles);
    }

    void Update() {
        if (alreadyInitialised) return;
        if (mix == null) return;
        if (GM.gmInstance == null) return;
        float value = PlayerPrefs.GetFloat("volume", 0);
        GM.gmInstance.SetVolume(value);
        try {
            slider = GameObject.FindWithTag("volume").GetComponent<Slider>();
        }
        catch {
            return;
        }
        slider.value = value;
        alreadyInitialised = true;
    }
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Volume(float volume)
    {
        if (!alreadyInitialised) return;
        GM.gmInstance.SetVolume(volume);
    }

    public void Particles(bool disable_particles)
    {
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
        GM.gmInstance.SetGraphics(quality);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
