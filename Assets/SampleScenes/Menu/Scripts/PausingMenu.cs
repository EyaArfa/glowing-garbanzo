using System;
using UnityEngine;
using UnityEngine.UI;

public class PausingMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    [SerializeField]
    public GameObject pauseMenuUI;

    public AudioSource music;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space ))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
                Pause();
        }

    }

     public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        music.Play();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
        music.Pause();
    }
}
