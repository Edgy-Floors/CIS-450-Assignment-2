/*
 * EJ Flores
 * Defend.cs
 * Assignment 2
 * This file is the class that adds shields to yourself.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : Spell
{
    Buff buff = new Buff();
    public override void castSpell()
    {
        base.numUsed++;
        base.sheild += 5;
        selectorText.text = buff.cast();
        myText.text = "Sheild: " + base.sheild;
    }
}
