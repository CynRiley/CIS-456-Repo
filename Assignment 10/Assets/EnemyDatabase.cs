using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Robyn Riley
 * EnemyDatabase.cs
 * Assignment 10
 * Handles creation of Enemy class objects within a dictionary
 */

public class EnemyDatabase : MonoBehaviour
{
    public Dictionary<string, Enemy> enemies;

    private void Start()
    {
        enemies = new Dictionary<string, Enemy>();
        enemies.Add("First", new Enemy());
        enemies.Add("Second", new Enemy("Jacob", 15));
        enemies.Add("Third", new Enemy("Sammy", 5));

        if (enemies.ContainsKey("Second"))
        {
            enemies.Remove("Second");
        }

        foreach(KeyValuePair<string, Enemy> i in enemies)
        {
            Debug.Log(i.Key + ": " + i.Value.ToString());
        }
    }
}
