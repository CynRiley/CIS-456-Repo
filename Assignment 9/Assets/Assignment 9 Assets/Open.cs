using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Robyn Riley
 * Open.cs
 * Assignment 9
 * Applies a force to the door when the player is detected
 */


public class Open : MonoBehaviour
{
    public float length;
    public float waitTime;
    public float openForce;

    bool open, pause;

    public LayerMask player;

    RaycastHit ray;

    private void FixedUpdate()
    {
        if (!pause)
        {
            Physics.Raycast(transform.position, transform.forward * length, out ray, length, player);
            Debug.DrawRay(transform.position, transform.forward * length, Color.magenta);
        }
        if (ray.collider != null)
        {
            Invoke("Swing", 0);
        }

    }

    private void Swing()
    {
        pause = true;

        GetComponent<Rigidbody>().AddForce(-transform.forward * openForce, ForceMode.Force);

        Invoke("Lock", .5f);

        Invoke("Close", waitTime);

    }

    private void Lock()
    {

        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    private void Close()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Invoke("Set", 1);
    }

    private void Set()
    {
        pause = false;
    }
}
