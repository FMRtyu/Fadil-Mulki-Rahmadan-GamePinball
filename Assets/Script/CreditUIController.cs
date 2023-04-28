using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditUIController : MonoBehaviour
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
