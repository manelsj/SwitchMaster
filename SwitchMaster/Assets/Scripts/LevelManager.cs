using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> LightList;
    private GameObject gameManager;
    public GameObject switchCounter;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager");
    }

    void Update()
    {
        if (AllLightsOn())
        {
            gameManager.GetComponent<GameManager>().NextLevel();
        }
    }

    private bool AllLightsOn()
    {
        bool lightsOn = true;

        foreach (var light in LightList)
        {
            if (light.GetComponent<LightScript>().GetIsOn() == false)
            {
                lightsOn = false;
            }
        }

        return lightsOn;
    }

    public void ResetLevel()
    {
        foreach (var light in LightList)
        {
            if (light.GetComponent<LightScript>().GetIsOn() == true)
            {
                light.GetComponent<LightScript>().SwitchLight();
            }
        }

        switchCounter.GetComponent<SwitchCounter>().ResetCount();
    }
}
