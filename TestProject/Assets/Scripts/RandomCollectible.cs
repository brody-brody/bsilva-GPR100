using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollectible : MonoBehaviour
{

	public ScoreScript score;
    
	private void OnTriggerEnter2D(Collider2D other)
	{
		RepositionCollectible();
	}
	
	void RepositionCollectible()
	{
		float newX = Random.Range(-9, 9);
		float newY = Random.Range(-3, 3);
		Vector2 newPos = new Vector2(newX, newY);
		transform.position = newPos;
		
		score.AddScore();
	}
}
