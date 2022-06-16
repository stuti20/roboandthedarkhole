using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanelone : MonoBehaviour
{
    public GameObject Panelone;

    public void PlayGame()
    {
        Panelone.SetActive(false);
        Time.timeScale = 1f;
    }
}
