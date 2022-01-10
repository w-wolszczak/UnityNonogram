using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
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
}
