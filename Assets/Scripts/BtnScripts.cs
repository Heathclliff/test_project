﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnScripts : MonoBehaviour {

    public Sprite firstLayer, secondLayer;
    public GameObject soundOn, soundOff;

    void Start()
    {
		if (gameObject.name == "Music") {
			if (PlayerPrefs.GetString ("Music") != "no") {
				soundOn.SetActive (true);
				soundOff.SetActive (false);
			} else {
				soundOn.SetActive (false);
				soundOff.SetActive (true);
			}
		}
    }

    void OnMouseDown () {
        GetComponent<SpriteRenderer>().sprite = secondLayer;
    }

	void OnMouseUp() {
        GetComponent<SpriteRenderer>().sprite = firstLayer;  
    }



    void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("AudioClick").GetComponent<AudioSource>().Play();
        }

        switch (gameObject.name)
        {
            case "Play":
                {
                    SceneManager.LoadScene("Play");
                    break;
                }
            case "Music":
                {
                    if (PlayerPrefs.GetString("Music") != "no")
                    {
                        PlayerPrefs.SetString("Music", "no");
                        soundOn.SetActive(false);
                        soundOff.SetActive(true);
                    }
                    else
                    {
                        PlayerPrefs.SetString("Music", "yes");
                        soundOn.SetActive(true);
                        soundOff.SetActive(false);
                    }
                    break;
                }
		case "home_btn":
			{
				SceneManager.LoadScene("main");
				break;
			}
        }
    }
}
