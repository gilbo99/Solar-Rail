using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{

    public List<TextMeshProUGUI> objectiveText;

    public List<TextMeshProUGUI> buttonText;
  
    public List<GameObject> borderColor;
    
    public TextMeshProUGUI interactText;
    public List<Slider> sliderList;
    


    
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
        objectiveText[0].text = header;
        objectiveText[1].text = line1;
        objectiveText[2].text = line2;
        objectiveText[3].text = line3;

    }

    public void ButtonUpdate(string key0, string key1 ,string key2)
    {
        buttonText[0].text = key0;
        buttonText[1].text = key1;
        buttonText[2].text = key2;    
    }

    public void borderChange(Color32 pickcolor)
    {
        for (int i = 0; i < borderColor.Count; i++)
        {
            borderColor[i].GetComponent<Image>().color = pickcolor;
            borderColor[i].GetComponent<Image>().color = pickcolor;
            borderColor[i].GetComponent<Image>().color = pickcolor;
            borderColor[i].GetComponent<Image>().color = pickcolor;

        }
    }



}
