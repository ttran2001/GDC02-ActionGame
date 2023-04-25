/*
using UnityEngine; 
using System.Collections;

public class Goal : MonoBehaviour
{

	[Header("Set Dynamically")]
	public int goalHealth = 5;

	VoidOnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "animal")
		{
			goalHealth--;
			if (goalHealth <= 0)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
		}
	}
}
*/