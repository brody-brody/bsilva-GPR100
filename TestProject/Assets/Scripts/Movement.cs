using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private float _xMove;
	private float _yMove;
	private Rigidbody2D _rb;
	public float speed = 10f;
	public bool canMove = true;
	
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
		if (canMove == true)
		{
        CheckInput();
		}
		else if (canMove == false)
		{
			_rb.velocity = Vector2.zero;
		}
    }
	
	void CheckInput()
	{
		_xMove = Input.GetAxis("Horizontal");
		_yMove = Input.GetAxis("Vertical");
	}
	
	private void FixedUpdate()
	{
		_rb.AddForce(new Vector2(_xMove, _yMove) * speed);
	}
}
