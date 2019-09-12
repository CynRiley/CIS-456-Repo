using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Robyn Riley
* PlayerControllerX.cs
* Assignment 3
* This script is what keeps the plane moving.
*/

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * GetComponentInParent<PlayerControllerX>().rotationSpeed);
    }
}
