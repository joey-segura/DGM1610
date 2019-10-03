﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu] 
public class FloatData : ScriptableObject
{
    public float value = 1f, minValue = 0, maxValue = 1f;
    public void UpdateValue(float amount)
    {
        value += amount;
    }
//check phone picture.
    public void UpdateValueRange(float amount)
    {
        if (value <= maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }
        
        if (value >= minValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = minValue;
        }
    }
}