using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField]
    private string newGameLevel;

    public GameObject continueButton;

    void Start()
    {
        continueButton.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelSaved"))
        {
            continueButton.SetActive(true);
        }
    }
    public void NewGameButton()
    {
        SceneManager.LoadScene("Game");
    }
    private void activateButton()
    {

    }
    public void LoadGameButton()
    {
        if (PlayerPrefs.HasKey("LevelSaved"))
        {
           // continueButton.SetActive(true);
            string levelToLoad = PlayerPrefs.GetString("LevelSaved");
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
