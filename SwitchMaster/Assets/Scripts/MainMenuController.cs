using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button startButton;
    public GameObject gameManager;

    public void StartGame()
    {
        gameManager.GetComponent<GameManager>().DeactivateMainMenu();
        gameManager.GetComponent<GameManager>().OpenLevel(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
