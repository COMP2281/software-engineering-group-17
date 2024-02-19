using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class S_main_menu_buttons : MonoBehaviour
{
    public AudioMixer mix;
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

    public void Particles(bool enable_particles)
    {

    }
}
