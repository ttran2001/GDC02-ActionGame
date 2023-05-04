using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    static public float healthValue = 100f;
    [SerializeField] Text health;

    // Update is called once per frame
    void Update()
    {
        health.text = "Health: " + healthValue; 
    }
}
