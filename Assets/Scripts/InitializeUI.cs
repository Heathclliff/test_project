using UnityEngine;

public class InitializeUI : MonoBehaviour {

	public GameObject musicBtnsPrefabs;
	public GameObject playBtnsPrefabs;

	private GameObject musicBtns;
	private GameObject playBtns;

	private Vector2 musicBtnPosition = new Vector2 (-2f, -3f);
	private Vector2 playBtnPosition = new Vector2 (0f, 0f);

	void Start () {
		musicBtns = (GameObject)Instantiate (musicBtnsPrefabs,musicBtnPosition , Quaternion.identity);
		playBtns = (GameObject)Instantiate (playBtnsPrefabs, playBtnPosition, Quaternion.identity);

	}
}
