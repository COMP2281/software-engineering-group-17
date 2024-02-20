using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject pauseMenu;
    public GameObject optionsMenu;

    public GameObject optionsFirst;
    public GameObject pauseFirst;

    public Toggle particle;
    public Slider volumeSlider;

    private void Start()
    {
        particle.isOn = GM.gmInstance.GetParticle();
        volumeSlider.value = GM.gmInstance.GetVolume();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        MainMenu();
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void MainMenu()
    {
        pauseMenu.SetActive(true);
        optionsMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(pauseFirst);
    }

    public void OptionsMenu()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirst);
        
    }

    public void Volume(float volume)
    {
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




}
