using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
	private int _score = 0;
	public void AddScore()
	{
		_score += 50;
		scoreText.text = _score.ToString();
	}
}
