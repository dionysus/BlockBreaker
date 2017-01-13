using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public AudioClip crack;

	public Sprite[] hitSprites; //collect the sprites to change on hit
	public static int breakableCount = 0;

	private LevelManager LevelManager;
	private bool isBreakable;
	private int timesHit;

	// Use this for initialization
	void Start () {

		isBreakable = (this.tag == "Breakable");

		if (isBreakable) {
			breakableCount++;
			print (breakableCount);
		}

		timesHit = 0;
		LevelManager = GameObject.FindObjectOfType<LevelManager> ();
			
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D collision) {

		//this.GetComponent<AudioSource> ().Play();

		if (isBreakable) {
			HandleHits ();
		}

			
	}

	void HandleHits (){
	
		timesHit++;

		int maxHits = hitSprites.Length + 1;

		if (timesHit >= maxHits) {

			AudioSource.PlayClipAtPoint (crack, transform.position, 0.8f);

			breakableCount--;
			print (breakableCount);

			Destroy (gameObject);

			LevelManager.BrickDestroyed (); //is last brick?

		} else {

			LoadSprites ();

		}

	}

	void LoadSprites () {
	
		int spriteIndex = timesHit - 1;

		// only if the sprite has been loaded into the correct index
		if (hitSprites[spriteIndex]){
				this.GetComponent<SpriteRenderer>().sprite = hitSprites [spriteIndex];
			}

	}


	//TODO Remove this method once we can actually win!

	void SimulateWin(){

		LevelManager.LoadNextLevel();

	}

}
