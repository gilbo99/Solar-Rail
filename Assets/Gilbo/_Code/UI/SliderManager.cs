using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{

    
    public List<Slider> sliderList;
  

    public void BatterySlider(float charge, int selectedcell)
    {
        sliderList[selectedcell].value = charge;

    }
}
