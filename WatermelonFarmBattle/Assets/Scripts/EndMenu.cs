using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndMenu : MonoBehaviour
{
   public void RestartGame(){
        SceneManager.LoadScene("Start Screen 1"); // Load the Start Menu Scene
   }
}