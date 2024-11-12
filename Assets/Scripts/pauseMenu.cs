using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject P_Menu;
    public static bool isPaused;


     void Start()
     {
        Time.timeScale = 1.0f;
        isPaused = false;
        P_Menu.SetActive(false);
     }


    public void PauseGame()
    {
        P_Menu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        P_Menu.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = false;
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
}
