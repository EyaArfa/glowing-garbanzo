using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
  
   public void Next_Level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale = 1f;
        CoinsScript.theScore = 0;

        Scoring.scoreAmount = 0;
        Scoring.iniScore = 0;
        CollectKey.collect = false;
        WinningPanel.isWon = false;
    }
}
