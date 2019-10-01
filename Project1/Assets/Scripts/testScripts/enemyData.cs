using UnityEngine;

public class enemyData : MonoBehaviour
{
    public string enemyName;
    public float speed = 5f;
    public GameObject enemy;


    void Start()
    {
        Instantiate(ConfigGameObject());
    }

    //Create Player;
    private GameObject ConfigGameObject()
    {
        enemy.layer = 0;
        enemy.tag = "Player";
        enemy.transform.position = Vector3.zero;
        enemy.name = enemyName;

        return enemy;
    }
}