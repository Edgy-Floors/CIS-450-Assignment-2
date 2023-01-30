/*
 * EJ Flores
 * Buff.cs
 * Assignment 2
 * This file is the implementation of the Castable interface for buff spells.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff : ICastable
{
    public string cast()
    {
        return ("You casted a buff spell");
    }
}
