using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class WinningPanel : MonoBehaviour
{
    public GameObject panel;
    public GameObject score;
    public GameObject time;
    public GameObject coin;
    public GameObject image;
    public GameObject lives;
    public GameObject note;

    public TextMeshProUGUI text;
    private int HighScore;

    public AudioSource music,music1;
    

    public static bool isWon = false;

    void Start()
    {
        text.text = PlayerPrefs.GetInt("highScore", 0).ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MaleFree1" && CollectKey.collect)
        {
            panel.SetActive(true);
            coin.SetActive(false);
            time.SetActive(false);
            score.SetActive(false);
            image.SetActive(false);
            lives.SetActive(false);

            HighScore = PlayerPrefs.GetInt("highScore", 0);
            text.text = HighScore.ToString();
            music1.Pause();
            music.Play();
            isWon = true;
        }
        else if (collision.gameObject.name == "MaleFree1" && !CollectKey.collect)
        {
            note.SetActive(true);
        }
        
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "MaleFree1" && note.activeSelf)
        {
            note.SetActive(false);
        }
    }
}
