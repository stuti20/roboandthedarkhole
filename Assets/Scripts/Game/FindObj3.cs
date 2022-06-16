using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObj3 : MonoBehaviour
{

    public GameObject Panelthree;

    void Start()
    {
        Panelthree.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Objectthree"))
        {
            Destroy(collision.gameObject);
            Panelthree.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
