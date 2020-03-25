using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void GoToMore()
    {
        SceneManager.LoadScene("More");
    }
}
