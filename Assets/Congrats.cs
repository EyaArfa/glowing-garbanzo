using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class Congrats : MonoBehaviour
{
    public TextMeshProUGUI tScore;
    public int score;

    public TextMeshProUGUI tTime;
    public int time;

    public TextMeshProUGUI tCoin;
    public int coin;

    public TextMeshProUGUI tImage;
    public int image;

    public TextMeshProUGUI tLives;
    public int lives;

    public TextMeshProUGUI text;
    private int HighScore;

    // Start is called before the first frame update
    void Start()
    {
        coin = PlayerPrefs.GetInt("finalCoin", 0);
        time = PlayerPrefs.GetInt("finalTime", 0);
        score = PlayerPrefs.GetInt("finalTime", 0);
        lives = PlayerPrefs.GetInt("finalLives",0);

        HighScore = PlayerPrefs.GetInt("highScore", 0);
        text.text = HighScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
