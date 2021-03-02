using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class OptionsMenu : MonoBehaviour
{
    private int Invert;
    private string back;
    Toggle inGameToggle;
    
    void Start()
    {
        inGameToggle = GameObject.Find("InvertYToggle").GetComponent<Toggle>();
        back = PlayerPrefs.GetString("SceneNumber");
        PlayerPrefs.SetString("SceneNumber", SceneManager.GetActiveScene().name);
        Invert = PlayerPrefs.GetInt("invertedY");
        if (Invert == 1)
            inGameToggle.isOn = true;
        else
            inGameToggle.isOn = false;
    }
    public void Back()
    {
        SceneManager.LoadScene(back);
    }

    public void Apply()
    {
        if (inGameToggle.isOn)
        {
            PlayerPrefs.SetInt("invertedY", 1);
            Back();
        }
        else
        {
            PlayerPrefs.SetInt("invertedY", 0);
            Back();
        }
    }
}
