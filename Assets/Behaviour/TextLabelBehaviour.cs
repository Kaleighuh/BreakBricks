using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Globalization;

public class TextLabelBehaviour : MonoBehaviour
{
    public Text label;
    public UnityEvent startEvent;
    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
    
}