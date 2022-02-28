using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverMenuUI;

    //gameOverMenuUI.SetActive(true);
    //Time.timeScale = 0f;

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }

}
