using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Robyn Riley
 * CollectibleSpawnManager.cs
 * Assignment 10
 * Handles creation and placement of differently colored game objects
 */

public class CollectibleSpawnManager : MonoBehaviour
{
    public List<GameObject> collectibles;

    public List<GameObject> multicolorCollectibles;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject itemToPaint = Instantiate(collectibles[Random.Range(0, 3)]);
                itemToPaint.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1, 0, .5f);
                multicolorCollectibles.Insert(Random.Range(0, multicolorCollectibles.Count + 1), itemToPaint);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Vector3 spawnPos = GameObject.Find("RigidBodyFPSController").transform.position + (GameObject.Find("RigidBodyFPSController").transform.forward * 5);
            spawnPos = new Vector3(spawnPos.x + Random.Range(-5, 5), spawnPos.y, spawnPos.z + Random.Range(-5, 5));
            Instantiate(multicolorCollectibles[multicolorCollectibles.Count - 1], spawnPos, Quaternion.identity);
            multicolorCollectibles.RemoveAt(multicolorCollectibles.Count - 1);
        }
    }

}
