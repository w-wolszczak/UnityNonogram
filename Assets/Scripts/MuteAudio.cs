using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite SoundOffImage;
    public Button button;
    private bool isOn = true;

    private AudioSource AudioSource;
    public GameObject ObjectMusic;

    void Start()
    {
        ObjectMusic = GameObject.FindWithTag("GameMusic");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();
        soundOnImage = button.image.sprite;
    }
    void Update()
    {

    }
public void ButtonClicked()
    {
        if(isOn)
        {
            button.image.sprite = SoundOffImage;
            isOn = false;
            AudioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            AudioSource.mute = false; 
        }
    }
}
