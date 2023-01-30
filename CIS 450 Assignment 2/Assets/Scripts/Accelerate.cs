/*
 * EJ Flores
 * Accelerate.cs
 * Assignment 2
 * This file is the class that ups your personal speed value.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate : Spell
{
    Buff buff = new Buff();
    public override void castSpell()
    {
        base.numUsed++;
        base.speed += 1.9F;
        selectorText.text = buff.cast();
        myText.text = "Speed: " + base.speed;
    }
}
