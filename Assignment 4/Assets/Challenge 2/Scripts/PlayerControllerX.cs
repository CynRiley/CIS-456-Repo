using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
       * Robyn Riley
       * PlayerControllerX.cs
       * Assignment 4
       * Checks if an object is out of bounds, and destroys it if so
       */

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float spawnLimit = .5f;
    float next = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > next)
        {
            next = Time.time + spawnLimit;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
