﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class playerData : gameArtData
{
    public weaponData weapon;
    public clothesData shirt;
    public clothesData pants;
    public List<weaponData> weapons;

    public void instancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }
}