using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keygo : MonoBehaviour
{

    public GameObject winner;

    // Start is called before the first frame update
    void Start()
    {
        winner.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hit"))
        {
            
            winner.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
