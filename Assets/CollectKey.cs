using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public AudioSource music;

    public static bool collect = false;
    void OnTriggerEnter(Collider other)
    {

        if (other.name == "MaleFree1")
        {
            music.Play();
            collect = true;
            Destroy(gameObject);//destroys key

        }
    }
}
