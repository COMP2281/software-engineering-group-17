using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

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
    public TMPro.TMP_Dropdown graphicsDropdown;

    public GameObject combatText;
    private void Start()
    {
        particle.isOn = GM.gmInstance.GetParticle();
        volumeSlider.value = GM.gmInstance.GetVolume();
        graphicsDropdown.value = GM.gmInstance.GetGraphics();
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

    public void SkillsBuild()
    {
        Application.OpenURL("https://www.ibm.com/academic/home");
    }

    public void SkipLevel()
    {
        var nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log(GetSceneNameByBuildIndex(nextSceneIndex));
        if (SceneManager.GetActiveScene().name != "Cloud World Combat")
        {
            if (GetSceneNameByBuildIndex(nextSceneIndex) != "Cloud World Combat")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Resume();
            }
            else
            {
                
                DisplayText();
            }
        }
        else
        {
            
            DisplayText();
        }
    }


    private void DisplayText()
    {
        combatText.SetActive(true);
        StartCoroutine(DisableText());
    }

    IEnumerator DisableText()
    {
        yield return new WaitForSecondsRealtime(3);
        combatText.SetActive(false);
    }

    private static string GetSceneNameByBuildIndex(int buildIndex)
    {
        return GetSceneNameFromScenePath(SceneUtility.GetScenePathByBuildIndex(buildIndex));
    }

    private static string GetSceneNameFromScenePath(string scenePath)
    {
        // Unity's asset paths always use '/' as a path separator
        var sceneNameStart = scenePath.LastIndexOf("/", StringComparison.Ordinal) + 1;
        var sceneNameEnd = scenePath.LastIndexOf(".", StringComparison.Ordinal);
        var sceneNameLength = sceneNameEnd - sceneNameStart;
        return scenePath.Substring(sceneNameStart, sceneNameLength);
    }

    public void SetQuality(int quality)
    {
        GM.gmInstance.SetGraphics(quality);
    }



}
