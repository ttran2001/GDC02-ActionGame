using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    [SerializeField] Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue; 
    }
}
