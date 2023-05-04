using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class StartMenu : MonoBehaviour
{
    public void StartGame(){
        HealthScript.healthValue = 100;
		ScoreScript.scoreValue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); // Load the first level screen when user hits the Start Menu button
    }
}