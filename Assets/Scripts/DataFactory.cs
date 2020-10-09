using System;
using UnityEngine.UI;
using UnityEngine;

public class DataFactory
{
    public static Button GetButtonCompute()
    {
        return GameObject.FindObjectOfType<Button>();
    }

    public static InputField GetFirstFactorInput()
    {
        return GameObject.Find("FirstFactor").GetComponentInChildren<InputField>();
    }

    public static InputField GetSecondFactorInput()
    {
        return GameObject.Find("SecondFactor").GetComponentInChildren<InputField>();
    }

    public static Text GetUIResult()
    {
        return GameObject.Find("Result").transform.GetChild(1).GetComponent<Text>();
    }

    public static Dropdown GetDropDown()
    {
        return GameObject.FindObjectOfType<Dropdown>();
    }
}