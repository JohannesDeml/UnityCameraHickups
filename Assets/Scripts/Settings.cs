using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Settings : MonoBehaviour {

    [Tooltip("Disables screen shutdown when true")]
    [SerializeField]
    private bool neverTurnOfScreen = true;
    [Tooltip("When enabled assertions will raise exceptions")]
    [SerializeField]
    private bool AssertionsRaiseExceptions = true;
    [Tooltip("Set a frame rate lock, to get iOS to use that frame rate and help android not to do too much work\n" +
             "Set to -1 to disable the feature")]
    [SerializeField]
    private int targetFrameRate = 60;

    void Awake()
    {
        if (neverTurnOfScreen)
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }
        UpdateFrameRate();
        
        Assert.raiseExceptions = AssertionsRaiseExceptions;
    }

    private void UpdateFrameRate()
    {
        if (targetFrameRate > 0)
        {
            Application.targetFrameRate = targetFrameRate;
        }
        else
        {
            Application.targetFrameRate = -1;
        }
    }

    public void ParseTargetFrameRate(string newFrameRate)
    {
        SetTargetFrameRate(Int32.Parse(newFrameRate));
    }

    public void SetTargetFrameRate(int newFrameRate)
    {
        targetFrameRate = newFrameRate;
        UpdateFrameRate();
    }
}
