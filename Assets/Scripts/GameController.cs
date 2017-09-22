using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController instanse;

	public GameObject coreCanvasPrefabs;
	private GameObject coreCanvas;

	public GameObject canvasPrefabs;
	private GameObject canvas;
	private Vector2 canvasPosition = new Vector2(0f,0f);

	public GameObject btnsPrefabs;
	private GameObject btns;
	private Vector2 btnPosition = new Vector2 (0f, -2f);

	public bool gameOver = false;

	void Awake(){
		if (instanse == null) {
			instanse = this;
		} else if (instanse != this) {
			Destroy (gameObject);
		}

		coreCanvas =(GameObject)Instantiate (coreCanvasPrefabs,canvasPosition , Quaternion.identity);
	}

	void Start () {
		endOfgame ();

	}

	// Update is called once per frame
	void Update () {
		
	}

	void endOfgame(){
		gameOver = true;
		canvas =(GameObject)Instantiate (canvasPrefabs,canvasPosition , Quaternion.identity);
		canvas.SetActive (true);

		btns = (GameObject)Instantiate (btnsPrefabs,btnPosition , Quaternion.identity);
		btns.SetActive (true);

		//loseCanvas.gameObject.SetActive (true);
	}
}
