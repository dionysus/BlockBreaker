using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;

	public float minY, maxY;

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

		Vector3 paddlePos = new Vector3 (this.transform.position.x, 8f, 0f); //keep current y
		float mousePosInBlocks = Input.mousePosition.y / Screen.height * 9; //find position of mouse and set to game units (16)
		paddlePos.y = Mathf.Clamp(mousePosInBlocks, minY , maxY); //restrict to screen
		this.transform.position = paddlePos;
	
	}


	void AutoPlay (){
		
		Vector3 paddlePos = new Vector3 (this.transform.position.x, 8f, 0f); //keep current y 
		paddlePos.y = Mathf.Clamp(ball.transform.position.y, minY, maxY);
		this.transform.position = paddlePos;

	}

}
