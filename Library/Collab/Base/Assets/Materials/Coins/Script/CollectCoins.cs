using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoins : MonoBehaviour
{

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
            GetComponent<AudioSource>().Play();
            CoinsScript.theScore += 1;
            Destroy(gameObject);//destroys coin
        }
    }

    
}
