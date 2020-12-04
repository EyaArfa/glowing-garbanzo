using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bmenu : MonoBehaviour
{
    public GameObject panel;
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Name()
    {
        panel.SetActive(true);
    }
}
