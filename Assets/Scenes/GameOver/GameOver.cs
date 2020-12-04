using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    public class GameOver : MonoBehaviour
{
    public static bool isRestart;
    public static bool isResume;


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        CoinsScript.theScore = 0;
        Time.timeScale = 1f;
        Scoring.scoreAmount = 0;
        Scoring.iniScore = 0;
        isRestart = true;
        WinningPanel.isWon = false;

        CollectKey.collect = false;
    }
    public void MainScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        
    }

    public void Resume()
    {
        isResume = true;

    }



}
