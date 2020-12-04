using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

    public void level01()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
        CoinsScript.theScore = 0;

        Scoring.scoreAmount = 0;
        Scoring.iniScore = 0;
        CollectKey.collect = false;
        WinningPanel.isWon = false;

    }

    public void level02()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
        CoinsScript.theScore = 0;

        Scoring.scoreAmount = 0;
        Scoring.iniScore = 0;
        CollectKey.collect = false;
        WinningPanel.isWon = false;
    }

    public void level03()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;
        CoinsScript.theScore = 0;

        Scoring.scoreAmount = 0;
        Scoring.iniScore = 0;
        CollectKey.collect = false;
        WinningPanel.isWon = false;
    }
}
