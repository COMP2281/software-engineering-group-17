using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

public class MainMenuButtons : MonoBehaviour
{
    public AudioMixer mix;

    public GameObject optionsOutButton;
    public GameObject optionsInButton;

    public GameObject optionsMenu;
    public GameObject mainMenu;
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
        mix.SetFloat("volume", volume);
        Debug.Log(volume);
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

}
