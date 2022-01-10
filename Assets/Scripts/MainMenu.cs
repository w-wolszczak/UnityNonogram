using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Slider slider;
    public Text sliderText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Row"))
        {
            slider.value = PlayerPrefs.GetInt("Row");
        }
        else
        {
            slider.value = slider.minValue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = slider.value + "";
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Player()
    {
        PlayerPrefs.SetInt("Row", (int)slider.value);
        PlayerPrefs.SetInt("Column", (int)slider.value);

        SceneManager.LoadScene("Game");
    }
}
