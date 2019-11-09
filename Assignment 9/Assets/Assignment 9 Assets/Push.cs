using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Robyn Riley
 * Push.cs
 * Assignment 9
 * Launches the player when they pass over the trigger.
 */

public class Push : MonoBehaviour
{
    public ForceMode force;
    public float amount;

    private void OnTriggerEnter(Collider other)
    {
        if(force == ForceMode.Impulse || force == ForceMode.VelocityChange)
        {
            Debug.Log(force);
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * amount);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(force == ForceMode.Acceleration || force == ForceMode.Force)
        {
            Debug.Log(force);
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * amount);
        }
    }
}
