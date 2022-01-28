using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public bool playing = false;
    //  public GameObject pausePanel, winPanel;
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);

    }

    //public void LoadEasyGame(string name)
    // {
    //    GameSettings.Instance.SetGameMode(GameSettings.EGameMode.EASY);
    //   SceneManager.LoadScene(name);

    //  }
    //public void LoadMediumGamee(string name)
    //{
    //  GameSettings.Instance.SetGameMode(GameSettings.EGameMode.MEDIUM);
    //SceneManager.LoadScene(name);

    //    }
    //  public void LoadHardGame(string name)
    //{
    //  GameSettings.Instance.SetGameMode(GameSettings.EGameMode.HARD);
    //SceneManager.LoadScene(name);

    //}

    public void ActivateObject(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void DeactivateObject(GameObject obj)
    {
        obj.SetActive(false);
    }
   /* public void Pause()
    {
        // time = this.time;
        //playing = false;
        //gamePaused = true;
        pausePanel.SetActive(true);
        winPanel.SetActive(false);
    }*/
}
