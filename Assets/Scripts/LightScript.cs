using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class LightScript : MonoBehaviour, IPointerDownHandler
{
    public Material lightOn;
    public Material lightOff;
    private bool isOn = false;

    public LightScript upLight;
    public LightScript downLight;
    public LightScript leftLight;
    public LightScript rightLight;

    public bool blockedLight;

    private GameObject switchCounter;

    void Start()
    {
        switchCounter = GameObject.FindWithTag("Counter");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!blockedLight)
        {
            SwitchLight();

            if (upLight) upLight.SwitchLight();
            if (downLight) downLight.SwitchLight();
            if (leftLight) leftLight.SwitchLight();
            if (rightLight) rightLight.SwitchLight();

            switchCounter.GetComponent<SwitchCounter>().IncreaseCount();
        }

    }

    public void SwitchLight()
    {
        if (isOn)
        {
            gameObject.GetComponent<SpriteRenderer>().material = lightOff;
            isOn = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().material = lightOn;
            isOn = true;
        }

    }

    public bool GetIsOn()
    {
        return isOn;
    }
}
