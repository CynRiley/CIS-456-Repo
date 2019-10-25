using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Robyn Riley
* Display.cs
* Assignment 8
* Script that makes changes based on trigger collision
*/

public class Display : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UIManager.instance.DisplayPrompt();
        SpawnManager.instance.Stop();
    }
}
