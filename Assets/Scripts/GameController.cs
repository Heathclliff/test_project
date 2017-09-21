using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController instanse;
	public Canvas loseCanvas;
	public bool gameOver = false;

	void Awake(){
		if (instanse == null) {
			instanse = this;
		} else if (instanse != this) {
			Destroy (gameObject);
		}
	}

	void Start () {
		endOfgame ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void endOfgame(){
		gameOver = true;
		loseCanvas.gameObject.SetActive (true);
	}
}
