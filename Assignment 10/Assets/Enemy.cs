using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Robyn Riley
 * Enemy.cs
 * Assignment 10
 * Base Enemy Class
 */

public class Enemy
{
    public string name { get; set; }
    public float speed { get; set; }
    public static int count { get; set; }
    public int health { get; set; }


    public Enemy()
    {
        name = "Bob";
        speed = 10;
        count++;
    }

    public Enemy(string given, int amount)
    {
        name = given;
        speed = amount;
        count++;
    }


    public override string ToString()
    {
        return "Name: " + name + "\tSpeed: " + speed + "\tHealth: " + health + "\tNumber Made: " + count;
    }

}
