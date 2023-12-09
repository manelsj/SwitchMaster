using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> Levels;
    private int currentLevel = 0;

    public GameObject mainMenu;
    public GameObject switchCounter;

    public void OpenLevel(int level)
    {
        Levels[level].SetActive(true);
        switchCounter.SetActive(true);
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
        
    }

    public void ActivateMainMenu()
    {
        mainMenu.SetActive(true);
    }

    public void DeactivateMainMenu()
    {
        mainMenu.SetActive(false);
    }
}
