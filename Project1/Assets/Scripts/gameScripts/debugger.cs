using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class debugger : ScriptableObject
{
    public void onDebug(string words)
    {
        Debug.Log(words);
    }
}
