﻿using UnityEngine;
using System.Collections;

public class Dinosaur2Move : MonoBehaviour {

    private float gameSpeed = 5;
    private float maxSpeed = 10;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
        gameSpeed = 5;
	}
    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (gameSpeed < maxSpeed) { 
            gameSpeed = gameSpeed * 2;
            }
        }
        if (Input.GetKey (KeyCode.D))
        {
            transform.Translate(Vector2.right * gameSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * gameSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * gameSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * gameSpeed * Time.deltaTime);
        }
    } // movement
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Finish")
        {
            Debug.Log("You win!");
        }
    }
}
