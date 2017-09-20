
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnScript : MonoBehaviour {

    public Sprite firstLayer, secondLayer;

	void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite=secondLayer;
        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("AudioClick").GetComponent<AudioSource>().Play();
        }
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = firstLayer;
    }

    void OnMouseUpAsButton()
    {
        //SceneManager.LoadScene("Play");
    }
}
