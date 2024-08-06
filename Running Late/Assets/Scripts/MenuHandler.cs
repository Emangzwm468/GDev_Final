using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] AudioSource SFX;

    public void buttonSound()
    {
        SFX.Play();
    }
    //When the player presses the Play button, it will bring them to the "Game" Scene
    public void Play()
    {
        SceneManager.LoadScene("Game");

    }

    //When the player presses the Exit button, it will exit out the game
    public void Quit()
    {
        Application.Quit();
    }
}
