using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> Levels;
    private int currentLevel = 0;

    public GameObject mainMenu;
    public GameObject switchCounter;
    public Button quitButton;

    public void OpenLevel(int level)
    {
        Levels[level].SetActive(true);
        Levels[currentLevel].GetComponentInChildren<LevelManager>().ResetLevel();
        quitButton.gameObject.SetActive(true);
    }

    public void NextLevel()
    {
        Levels[currentLevel].GetComponentInChildren<LevelManager>().ResetLevel();
        Levels[currentLevel].SetActive(false);
        currentLevel++;

        if (currentLevel < Levels.Count)
        {
            OpenLevel(currentLevel);
        }
        else
        {
            ActivateMainMenu();
        }
        
    }

    public void ActivateMainMenu()
    {
        mainMenu.SetActive(true);
        switchCounter.GetComponent<SwitchCounter>().Deactivate();
        quitButton.gameObject.SetActive(false);
    }

    public void DeactivateMainMenu()
    {
        mainMenu.SetActive(false);
    }

    public void QuitToMainMenu()
    {
        Levels[currentLevel].GetComponentInChildren<LevelManager>().ResetLevel();
        Levels[currentLevel].SetActive(false);
        currentLevel = 0;
        

        ActivateMainMenu();
    }
}
