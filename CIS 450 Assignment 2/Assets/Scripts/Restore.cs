/*
 * EJ Flores
 * Restore.cs
 * Assignment 2
 * This file is the class that restores health to yourself.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restore : Spell
{
    Heal heal = new Heal();
    public override void castSpell()
    {
        base.numUsed++;
        base.health += 10;
        selectorText.text = heal.cast();
        myText.text = "Health: " + base.health;
    }
}
