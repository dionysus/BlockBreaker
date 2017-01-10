using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	//public static int players = 0;

	static MusicPlayer instance = null;

	void Awake (){
	
		if (instance != null) {
			Destroy (gameObject);
			print ("Destroyed MPlayer");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
