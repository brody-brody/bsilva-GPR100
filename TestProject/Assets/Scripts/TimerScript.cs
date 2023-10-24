using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
	public float _timer = 1f;
	float startingTime = 30f;
	public Movement script;
	
	
    void Start()
    {
        _timer = startingTime;
    }

	void Update()
	{
		_timer -= 1 * Time.deltaTime;
		timerText.text = _timer.ToString("0");
		
		if (_timer <= 0) 
		{
			_timer = 0;
			StopGame();
		}
	}
	
	public void StopGame()
	{
		script.canMove = false;
	}
}
