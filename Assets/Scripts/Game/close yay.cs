using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeyay : MonoBehaviour
{
    public GameObject teddy;

    public void PlayGame()
    {
        teddy.SetActive(false);
        Time.timeScale = 1f;
    }
}
