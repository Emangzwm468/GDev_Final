using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;


    public void gameOver()
    {
        GameOverUI.SetActive(true);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
