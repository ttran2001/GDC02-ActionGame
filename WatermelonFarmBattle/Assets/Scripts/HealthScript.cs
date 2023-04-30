using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthScript : MonoBehaviour
{
    public static int healthValue = 100; 
    Text health;

    void Start()
    {
        health = GetComponent<Text> (); 
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "Health: " + healthValue; 
    }
}
