using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanelThree : MonoBehaviour
{
    public GameObject Panelthree;

    public void PlayGame()
    {
        Panelthree.SetActive(false);
        Time.timeScale = 1f;
    }
}
