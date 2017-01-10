using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	//public to make accessible outside of class
	public void LoadLevel (string name) {  
		
		Debug.Log ("LoadLevel requested for:" + name); //use debug.log to output to console for testing

		SceneManager.LoadScene (name);
		//Application.LoadLevel (name); //load level by name of scene (outdated)


	}

	public void QuitRequest () {  //dont need anything in brackets as we wont be requiring a name

		Debug.Log ("QuitRequest requested");

		Application.Quit ();

	}

}
