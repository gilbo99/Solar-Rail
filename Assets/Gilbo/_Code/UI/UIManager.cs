using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    public List<Slider> sliderList;
    // Start is called before the first frame update


    public void UpdateUIText(string setWord)
    {
        interactText.text = setWord;

    }
    public void BatterySlider(float charge, int selectedcell)
    {
        sliderList[selectedcell].value = charge;

    }
}
