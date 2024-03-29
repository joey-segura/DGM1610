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