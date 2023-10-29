using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale = 1f;
    }
    public void quit()
    {
        Application.Quit();
        Time.timeScale = 1f;
    }
    public void pause()
    {
        Time.timeScale = 0f;

    }
    public void unpause()
    {
        Time.timeScale = 1f;
    }
}
