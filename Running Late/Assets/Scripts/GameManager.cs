using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;


    public void gameOver()
    {
        GameOverUI.SetActive(true);
    }
}
