using UnityEngine;
public class collide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "enemy")
        {
            this.gameObject.SetActive(false);
        }
    }
}
