using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class intData : ScriptableObject
{
    public int value = 1, minValue = 0, maxValue = 10;
    public void UpdateValue(int number)
    {
        value += number;
        if (value > maxValue)
        {
            value = maxValue;
        }
        if (value < minValue)
        {
            value = minValue;
        }
    }
}
