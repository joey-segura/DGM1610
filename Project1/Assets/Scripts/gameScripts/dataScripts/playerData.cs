using System.Collections.Generic;
using UnityEngine;

//INSTANTIATES PLAYER PREFAB AS "player(clone)"
[CreateAssetMenu]
public class playerData : gameArtData
{
    public weaponData weapon;
    public clothesData shirt;
    public clothesData pants;
    public List<weaponData> weapons;

    public void instancePlayer()
    {
        var newPlayer = Instantiate(prefab, new Vector3(-158,47,0), Quaternion.identity);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }
}
