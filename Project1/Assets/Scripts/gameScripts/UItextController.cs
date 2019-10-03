using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class UItextController : MonoBehaviour
{
    private Text textLabel;
    public void UpdateText(intData data)
    {
        textLabel.text = data.value.ToString();
    }
    void Awake()
    {
        textLabel = GetComponent<Text>();
    }
}
