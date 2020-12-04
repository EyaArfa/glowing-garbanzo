using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoins : MonoBehaviour
{
    public AudioSource music;
    private int score;
   /* public AudioSource audio;
     void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play()
    }*/
    void OnTriggerEnter(Collider other)
    {

        if (other.name == "MaleFree1")
        {
            music.Play();
            CoinsScript.theScore += 1;
            PlayerPrefs.SetInt("finalCoin", 0);
            Destroy(gameObject);//destroys coin
        }
    }

    
}
