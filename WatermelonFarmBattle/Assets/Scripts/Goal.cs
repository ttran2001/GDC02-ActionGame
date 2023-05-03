using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Cow"))
		{
			HealthScript.healthValue-=15;
			Destroy(other.gameObject);
		}
		if (other.gameObject.CompareTag("Sheep")){
			HealthScript.healthValue-=10;
			Destroy(other.gameObject);
		}
		if (other.gameObject.CompareTag( "Pig")){
			HealthScript.healthValue-=8; 
			Destroy(other.gameObject);
		}
		if(other.gameObject.CompareTag("Chicken") || other.gameObject.CompareTag("Duck")){
			HealthScript.healthValue-=5;
			Destroy(other.gameObject);		
		} 
		

		if (HealthScript.healthValue <= 0)
		{
			SceneManager.LoadScene("LoseScene");
		}
	}
}
