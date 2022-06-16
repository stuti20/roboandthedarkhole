using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charSound : MonoBehaviour
{
    public AudioSource someSound;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal"))
        {
            if (!someSound.isPlaying)
            {
                someSound.Play();
            }
        }

        if (Input.GetAxis("Horizontal"))
        {
            someSound.Stop();
        }
    }
}
