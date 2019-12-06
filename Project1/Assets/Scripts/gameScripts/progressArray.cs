using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progressArray : MonoBehaviour
{
    [SerializeField] private GameObject[] coins;
    void Start()
    {
        for (int i = 0; i < coins.Length; i++)
        {
            Debug.Log(coins[i].name + " still not found!");
        }
    }
}
