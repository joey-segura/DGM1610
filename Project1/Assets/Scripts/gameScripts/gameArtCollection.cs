using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class gameArtCollection : ScriptableObject
{
    public List<gameArtData> collectionList;

    public void AddData(gameArtData obj)
    {
        collectionList.Add(obj);
    }
}
