using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 paddlePos = new Vector3 (8f, this.transform.position.y , 0f); //keep current y

		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16; //find position of mouse and set to game units (16)

		paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f , 15.5f); //restrict to screen

		this.transform.position = paddlePos;

	}
}
