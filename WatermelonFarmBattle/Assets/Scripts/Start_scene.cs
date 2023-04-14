using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Start_scene : MonoBehaviour
{
    //Load Level 1
    public void SceneLoader()
    {
        SceneManager.LoadScene("Playground");
    }


}
