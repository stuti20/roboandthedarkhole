using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanelTwo : MonoBehaviour
{
    public GameObject Paneltwo;

    public void PlayGame()
    {
        Paneltwo.SetActive(false);
        Time.timeScale = 1f;
    }
}
