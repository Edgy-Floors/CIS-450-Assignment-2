/*
 * EJ Flores
 * Player.cs
 * Assignment 2
 * This file is the base spell class.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public float sheild = 0;
    public float speed = 2.5F;
    public bool slowGravity = false;

    public UnityEngine.UI.Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Health: " + health + "\nSheild: " + sheild + "\nSpeed: " + speed + "\nSlowGravity: " + slowGravity;
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Health: " + health + "\nSheild: " + sheild + "\nSpeed: " + speed + "\nSlowGravity: " + slowGravity;
    }
}
