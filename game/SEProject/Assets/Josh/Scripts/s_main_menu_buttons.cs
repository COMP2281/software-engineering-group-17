using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class S_main_menu_buttons : MonoBehaviour
{
    public AudioMixer mix;
    public Slider slider;
    private bool loadedMixer = false;
    private bool ready = false;
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Update() {
        if (ready) return;
        if (mix == null) return;
        float value = PlayerPrefs.GetFloat("volume", 0);
        mix.SetFloat("volume", value);
        try {
            slider = GameObject.FindWithTag("volume").GetComponent<Slider>();
        }
        catch {
            return;
        }
        slider.value = value;
        ready = true;     
    }


    public void Quit()
    {
        Application.Quit();
    }

    public void Volume(float volume)
    {
        if (!ready) return;
        mix.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
    }

    public void Particles(bool enable_particles)
    {

    }
}
