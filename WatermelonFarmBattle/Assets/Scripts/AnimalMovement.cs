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
            	Destroy(gameObject);
            	ScoreScript.scoreValue = ScoreScript.scoreValue+score;
            	if (ScoreScript.scoreValue > HighScore.score){
                	HighScore.score = ScoreScript.scoreValue;
            	}
        	}
    	}
    
    	if(other.gameObject.tag == "Garden")
    	{
        	Destroy(gameObject);
    	}
	}

}