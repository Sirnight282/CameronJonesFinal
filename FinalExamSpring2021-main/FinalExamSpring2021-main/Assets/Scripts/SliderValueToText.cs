using UnityEngine;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour
{

    public Slider sliderUI;
    public static float sliderValueFloat;
    public static Text SliderValue;

    //public static float SliderSpeed;
    // Start is called before the first frame update
    void Start()
    {
        SliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Time: " + sliderUI.value  + " Seconds";
        SliderValue.text = sliderMessage;
        sliderValueFloat = sliderUI.value;
        //Debug.Log(sliderValueFloat);
    }
}
