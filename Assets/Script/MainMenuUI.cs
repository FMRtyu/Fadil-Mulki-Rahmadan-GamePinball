using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button creditButton;
    public Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitButton);
        creditButton.onClick.AddListener(CreditButton);
    }
    private void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void ExitButton() 
    {
        Application.Quit();
        Debug.Log("exiting");
    }
    private void CreditButton()
    {
        SceneManager.LoadScene("Credit");
    }

}
