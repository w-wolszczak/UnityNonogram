using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveControl : MonoBehaviour
{

   
    public void Save(string name)
    {   //zapisuje nazwe nastepnego levelu pobierajac ja w przycisku next tak samo jak funkcja loadscene
        PlayerPrefs.SetString("LevelSaved", name);
        PlayerPrefs.Save();
        //Debug.Log(activeScene);
    }
    public void SaveDelete(string name)
    {   //usuwa nazwe zapisanego levelu pobierajac ja w przycisku next tak samo jak funkcja loadscene
        PlayerPrefs.DeleteKey(name);
       // PlayerPrefs.Save();
        //Debug.Log(activeScene);
    }


}
