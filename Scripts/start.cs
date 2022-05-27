using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    int currentlevel;
    void Start()
    {
        currentlevel = SceneManager.GetActiveScene().buildIndex;
    }


    public void StartLevel()
    {
        SceneManager.LoadScene(currentlevel + 1);

    }
    public void GameOver()
    {
        SceneManager.LoadScene(currentlevel - 1);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(currentlevel - 3);
    }
    public void GoBack()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void gameQuit()
    {
        Application.Quit();
    }
}
