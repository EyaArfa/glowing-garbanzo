using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI text;
    public static float scoreAmount;
    public float pointIncreasedPerSecond;
    public static int iniScore;

    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
        score = iniScore;

    }

    void Update()
    {
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime ;
        iniScore = (int)(scoreAmount * 1.69);
        score = iniScore;
        if (WinningPanel.isWon)
        {
            iniScore += (int)(250 - CountDown.timer) * 5;
            iniScore += Life_counter.Current_lives() * 167;
            iniScore += CoinsScript.theScore * 25;
            score = iniScore;
            Time.timeScale = 0f;

            PlayerPrefs.SetInt("finalScore", score);

            if (score > PlayerPrefs.GetInt("highScore", 0))
            {
                PlayerPrefs.SetInt("highScore", score);
            }
        }

        text.text = score.ToString();

        
    }
    
}
