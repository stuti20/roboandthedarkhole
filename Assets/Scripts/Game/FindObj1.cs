using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObj1 : MonoBehaviour
{

    public GameObject Panelone;

    void Start()
    {
        Panelone.SetActive(false);
        Time.timeScale = 1f;
    } 


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Objectone"))
        {
            Destroy(collision.gameObject);
            Panelone.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
