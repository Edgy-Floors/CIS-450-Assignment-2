/*
 * EJ Flores
 * Heal.cs
 * Assignment 2
 * This file is the implementation of the Castable interface for healing spells.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : ICastable
{
    public string cast()
    {
        return ("You casted a heal spell.");
    }
}
