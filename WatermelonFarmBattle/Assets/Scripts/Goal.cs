using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

	[Header("Set Dynamically")]
	public int goalHealth = 5;

	void VoidOnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Cow")
		{
			goalHealth=goalHealth-15;
			
		}
		if (other.gameObject.tag == "Sheep"){
			goalHealth=goalHealth-10;
		}
		if (other.gameObject.tag == "Pig"){
			goalHealth=goalHealth-8; 
		}
		if(other.gameObject.tag == "Chicken" || other.gameObject.tag == "Duck"){
			goalHealth=goalHealth-5;
		} 

		if (goalHealth <= 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
