using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI objectiveUIHeader;
    public TextMeshProUGUI objectiveUILine1;
    public TextMeshProUGUI objectiveUILine2;
    public TextMeshProUGUI objectiveUILine3;

    public TextMeshProUGUI buttonLeft;
    public TextMeshProUGUI buttonMid;
    public TextMeshProUGUI buttonRight;
    

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

    public void ObjectiveUpdate(string header, string line1 , string line2 , string line3)
    {
        objectiveUIHeader.text = header;
        objectiveUILine1.text = line1;
        objectiveUILine2.text = line2;
        objectiveUILine3.text = line3;

    }

    public void ButtonUpdate(string key0, string key1 ,string key2)
    {
        buttonLeft.text = key0;
        buttonMid.text = key1;
        buttonRight.text = key2;    
    }



}
