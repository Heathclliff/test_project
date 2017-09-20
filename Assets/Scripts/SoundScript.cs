using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

    public GameObject soundOn, soundOff;

    void Start()
    {
        if (PlayerPrefs.GetString("Music") != "no")
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }
    }

    void OnMouseUpAsButton()
    {
        if(PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("AudioClick").GetComponent<AudioSource>().Play();
        }

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
    }
}
