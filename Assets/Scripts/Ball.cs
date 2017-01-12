using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 paddleToBallVector; //distance between ball and paddle
	private Rigidbody2D ball;
	private bool hasStarted = false; 


	// Use this for initialization
	void Start () {

		paddle = GameObject.FindObjectOfType<Paddle> (); //find paddles

		paddleToBallVector = this.transform.position - paddle.transform.position;

		ball = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (!hasStarted) {
			
			//lock ball to paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
		}

		if (Input.GetMouseButtonDown (0)) {
		
			hasStarted = true;

			this.ball.velocity = new Vector2 (2f, 10f);

		}
		
	}
}
