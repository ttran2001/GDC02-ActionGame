using UnityEngine;

public class AnimalMovement : MonoBehaviour
{

	[Header("Set ")]
	public GameObject goal; 
	public float speed; // animals speed
	public int health; // animals health
	public int score;

	// Update 
	void Update()
	{
		transform.Translate(0,0,1 * speed * Time.deltaTime); // Moves the

	}
	
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Pellet"))
		{
			health--; 
			
			if(health <= 0)
			{
				ScoreScript.scoreValue+=score; 
				Destroy(gameObject);
				 
			}
		}
		if(goal.gameObject.CompareTag("Garden"))
		{
			Destroy(gameObject);
		}
	}
}