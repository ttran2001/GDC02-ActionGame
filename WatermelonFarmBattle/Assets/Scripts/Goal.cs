using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Cow")
		{
			HealthScript.healthValue-=15;
			
		}
		if (other.gameObject.tag == "Sheep"){
			HealthScript.healthValue-=10;
		}
		if (other.gameObject.tag == "Pig"){
			HealthScript.healthValue-=8; 
		}
		if(other.gameObject.tag == "Chicken" || other.gameObject.tag == "Duck"){
			HealthScript.healthValue-=5;
			
		} 

		if (HealthScript.healthValue <= 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
