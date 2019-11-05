using UnityEngine;
public class collide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "enemyMelee")
        {
            this.gameObject.SetActive(false);
        }
    }
}
