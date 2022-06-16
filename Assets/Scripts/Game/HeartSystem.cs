using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    // Lives settings
    public float lives = 3;
    public Text livesText;
    public GameObject Panel;
    Vector3 startPosition;

    void Start()
    {
        // Set Live GUI
        if (livesText.name == "livesText")
        {
            livesText.text = "Lives:" + lives;
        }

        Panel.SetActive(false);
        Time.timeScale = 1f;
        startPosition = transform.position;
    }
    // Update is called once per frame

    void Update()
    {

        PlayerPrefs.SetFloat("lives", 4);
        PlayerPrefs.Save();
        if(lives <= 0)
        {
            Panel.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    // Die by collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("stone") || collision.gameObject.CompareTag("floor"))
        {
            Die();
            //Reset();
        }
    }

    // What happens when Die is called
    void Die()
    {
        lives = lives - 1 ;
        livesText.text = "Lives:" + lives;
        transform.position = startPosition;
    }

    void Awake()
    {
        startPosition = transform.position;
        print(startPosition);
    }
}
