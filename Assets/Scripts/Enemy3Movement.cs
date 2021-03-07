using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Movement : MonoBehaviour
{
    public float accelerationTime = 5f;
    public float maxSpeed = 1f;
    private Vector2 movement;
    private float timeLeft;
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0) {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }
    }

    void FixedUpdate() {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(movement * maxSpeed);    
    }
}
