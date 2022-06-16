using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObj2 : MonoBehaviour
{

    public GameObject Paneltwo;

    void Start()
    {
        Paneltwo.SetActive(false);
        Time.timeScale = 1f;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Objecttwo"))
        {
            Destroy(collision.gameObject);
            Paneltwo.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
