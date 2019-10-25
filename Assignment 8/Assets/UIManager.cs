using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
* Robyn Riley
* UIManager.cs
* Assignment 8
* Singleton that handles display of UI objects based on player actions
*/

public class UIManager : MonoBehaviour
{

    public static UIManager instance;
    Canvas world;
    private void Awake()
    {
        instance = this;
        world = FindObjectOfType<Canvas>();
        world.gameObject.SetActive(false);
    }

    public void DisplayPrompt()
    {
        StartCoroutine(Return());
        world.gameObject.SetActive(true);
    }

    IEnumerator Return()
    {
        yield return new WaitForSeconds(5);
        world.gameObject.SetActive(false);
    }
}
