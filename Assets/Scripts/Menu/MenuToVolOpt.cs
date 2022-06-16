using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToVolOpt : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("VolumeSetting");
    }
}
