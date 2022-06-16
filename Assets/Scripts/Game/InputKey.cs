using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputKey : MonoBehaviour
{
    public GameObject gameOver;
    public InputField mainInputField;
    public string myText;

    void Start()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Checkname()
    {
        /*myText = InputField.text;
        if (myText == "461")
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("yay");
        }
        else
        {
            Debug.Log("nay");
        }*/
        myText = mainInputField.text;
        if (myText == "461")
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("yay");
        }
        else
        {
            Debug.Log("nay");
        }

    }

   
}
