using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class progressArray : MonoBehaviour
{
    [SerializeField] private GameObject[] coins;
    public Text changingText;
    private void OnTriggerEnter(Collider other)
    {
        TextUpdate();
    }
    public void TextUpdate()
    {
        for (int i = 0; i < coins.Length; i++)
        {
            changingText.text = (coins[i].name + " still not found!");
        }
        changingText.text = "Congratulations! You collected all of the coins!";
    }
}
