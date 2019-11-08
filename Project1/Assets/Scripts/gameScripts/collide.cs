using UnityEngine;

public class collide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
