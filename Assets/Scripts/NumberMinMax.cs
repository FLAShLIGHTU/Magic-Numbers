using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class NumberMinMax : MonoBehaviour
{
    public InputField FromNum;
    public InputField ToNum;

    public static int MinNum;
    public static int MaxNum;


    void Start()
    {
    }

    void Update()
    {
        if (FromNum.text != String.Empty && ToNum.text != String.Empty)
        {
            MinNum = Convert.ToInt32(FromNum.text);
            MaxNum = Convert.ToInt32(ToNum.text);
        }

        else
        {
            MinNum = 0;
            MaxNum = 1000;
        }
    }
}