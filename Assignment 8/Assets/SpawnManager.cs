using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* Robyn Riley
* SpawnManager.cs
* Assignment 8
* Singleton that handles spawning of objects around player
*/

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;

    public GameObject box;
    GameObject player;
    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        player = GameObject.Find("ThirdPersonController");
        InvokeRepeating("Spawn", 0, 2);
    }

    void Spawn()
    {
        float x, y, z;
        y = player.transform.position.y + 10;
        x = Random.Range(player.transform.position.x + 5, player.transform.position.x - 5);
        z = Random.Range(player.transform.position.z, player.transform.position.z - 5);
        Vector3 spawnPos = new Vector3(x, y, z);

        Instantiate(box, spawnPos, Quaternion.identity);
    }

    public void Stop()
    {
        CancelInvoke();
    }
}
