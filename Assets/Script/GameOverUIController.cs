using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;

    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
    }
    private void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
