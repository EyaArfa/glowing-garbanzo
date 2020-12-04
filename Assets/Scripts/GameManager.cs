using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject gameover;

    [SerializeField]
    public GameObject pause;

    public AudioSource music;
    public AudioSource music1;

    public void FixedUpdate()
    {
        if (Life_counter.Current_lives() == 0 || (CountDown.timer == 0))
        {
            music.Pause();
            music1.Play();
        }
    }

    public void Update()
    {
        if(Life_counter.Current_lives()==0 || (CountDown.timer == 0) )
        {
            gameover.SetActive(true);
            Time.timeScale = 0f;
            
        }
        
        if (GameOver.isRestart)
        {
            Time.timeScale = 1f;

            



            if (Life_counter.Current_lives() == 0 || (CountDown.timer == 0))
            {
                gameover.SetActive(true);
                Time.timeScale = 0;
            }

            if (pause.activeSelf)
            {
                Time.timeScale = 0;
            }
            
            /*if (PausingMenu.GameIsPaused == false)
            {
                Time.timeScale = 1;
            }*/
        }

        if (GameOver.isResume)
        {
            Time.timeScale = 1f;
        }
    }
}
