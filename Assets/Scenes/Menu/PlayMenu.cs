using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        CoinsScript.theScore = 0;

        Scoring.scoreAmount = 0;
        Scoring.iniScore = 0;
        CollectKey.collect = false;
        WinningPanel.isWon = false;


    }
    public void Exit()
    {
        Application.Quit();
    }


}
