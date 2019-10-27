using UnityEngine;
public class collide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "enemy")
        {
            this.gameObject.SetActive(false);
        }
    }
}
