/*
 * EJ Flores
 * SlowFall.cs
 * Assignment 2
 * This file is the class that enables slow falling.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFall : Spell
{
    Buff buff = new Buff();
    public override void castSpell()
    {
        base.numUsed++;
        base.slowGravity = true;
        selectorText.text = buff.cast();
        myText.text = "SlowGravity: " + base.slowGravity;
    }
}
