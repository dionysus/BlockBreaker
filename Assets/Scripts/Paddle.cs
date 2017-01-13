using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;

	public float minX, maxX;

	private Ball ball;

	void Start () {

		ball = GameObject.FindObjectOfType<Ball> ();

	}

	void Update () {

		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay ();
		}
			
	}

	void MoveWithMouse (){

		Vector3 paddlePos = new Vector3 (8f, this.transform.position.y , 0f); //keep current y
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 9; //find position of mouse and set to game units (16)
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX , maxX); //restrict to screen
		this.transform.position = paddlePos;
	
	}


	void AutoPlay (){
		
		Vector3 paddlePos = new Vector3 (8f, this.transform.position.y , 0f); //keep current y 
		paddlePos.x = Mathf.Clamp(ball.transform.position.x, minX , maxX);
		this.transform.position = paddlePos;

	}

}
