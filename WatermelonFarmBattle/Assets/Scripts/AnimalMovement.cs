using UnityEngine;

public class AnimalMovement : MonoBehaviour
{

	[Header("Set ")]
	public float speed; // animals speed
	public int health; // animals health
	public int score;

	// Update 
	void Update()
	{
		transform.Translate(0,0,1 * speed * Time.deltaTime); // Moves the

	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Pellet")
		{
			health--; 
			
			if(health <= 0)
			{
				ScoreScript.scoreValue+=score; 
				Destroy(gameObject);
				 
			}
		}
		if(other.gameObject.tag == "Garden")
		{
			Destroy(gameObject);
		}
	}
}