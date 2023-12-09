using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class SwitchCounter : MonoBehaviour
{
    private int count = 0;
    public TMP_Text counterText;

    void Start()
    {
        counterText.text = ("Switch Count: " + count.ToString());
    }

    public void IncreaseCount()
    {
        count++;
        counterText.text = ("Switch Count: " + count.ToString());
    }

    public void ResetCount()
    {
        count = 0;
        counterText.text = ("Switch Count: " + count.ToString());
    }
}
