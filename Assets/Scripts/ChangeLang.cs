using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLang : MonoBehaviour
{

    private Sprite PLmenu;
    public Sprite ENGmenu;
    public Button button;
    private bool isOn = true;

    public GameObject ENGMenu, PLMenu;

    // Start is called before the first frame update
    void Start()
    {
        PLmenu = button.image.sprite;
        ENGMenu.SetActive(false);
        PLMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = ENGmenu;
            isOn = false;
            ENGMenu.SetActive(true);
            PLMenu.SetActive(false);
        }
        else
        {
            button.image.sprite = PLmenu;
            isOn = true;
            ENGMenu.SetActive(false);
            PLMenu.SetActive(true);
        }
    }
}
