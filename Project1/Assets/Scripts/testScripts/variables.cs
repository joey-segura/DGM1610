using UnityEngine;
using UnityEngine.Events;

public class variables : MonoBehaviour
{
	public float floatValue = 5f;
	public int intValue;
	public string stringValue = "Pixeltic";
	public int firePower;
	public UnityEvent Event;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Bomb")
		{
			print("GAME OVER");
			Destroy(this.gameObject);
			Destroy(GameObject.Find("Sparks"));
		}
	}
}