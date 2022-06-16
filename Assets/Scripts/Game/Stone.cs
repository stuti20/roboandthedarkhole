using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public float speed = 30.0f;
    public Rigidbody2D rb;
    private Vector2 bound;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        startPosition = transform.position;
        // bound = new Vector2(1, 42, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("killr"))
        {
            transform.position = startPosition;
        }
    }

    void Awake()
    {
        startPosition = transform.position;
        print(startPosition);
    }
}
