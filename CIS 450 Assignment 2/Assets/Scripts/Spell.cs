/*
 * EJ Flores
 * Spell.cs
 * Assignment 2
 * This file is the base spell class.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public int numUsed = 0;
    public int health = 100;
    public float sheild = 0;
    public float speed = 2.5F;
    public bool slowGravity = false;

    public UnityEngine.UI.Text myText;
    public UnityEngine.UI.Button btn;
    public UnityEngine.UI.Text selectorText;

    private void Start()
    {
        btn.onClick.AddListener(castSpell);
    }

    public abstract void castSpell();
}
