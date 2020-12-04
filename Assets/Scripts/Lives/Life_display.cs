using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_display : MonoBehaviour
{
    [SerializeField]
    private Image[] lives;

    [SerializeField]
    private Sprite empty;

    [SerializeField]
    private Sprite full;
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lives.Length; i++)
        {
            lives[i].sprite = full;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Life_counter.max_lives - Life_counter.Current_lives(); i++)
        {
            //Debug.Log(Life_counter.Current_lives());
            
            lives[lives.Length - 1- i].sprite = empty;
        }

        PlayerPrefs.SetInt("finalLives", Life_counter.Current_lives());

        
    }
}
