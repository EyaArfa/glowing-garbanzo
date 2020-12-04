using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoins : MonoBehaviour
{

    private int score;
    void OnTriggerEnter(Collider other)
    {

        if (other.name == "MaleFree1")
        {
           

            CoinsScript.theScore += 1;
            Destroy(gameObject);//destroys coin
        }
    }

    
}
