using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Battery : MonoBehaviour
{

    float batteryCharge;
    public TMP_Text batteryText;
    public TextMeshProUGUI batteryUI;
    public int batteryLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUIText(batteryCharge);

    }

    public void Charge(float SentBattery)
    {
        batteryCharge = SentBattery;
       
    }

    void UpdateUIText(float setWord)
    {
        batteryLevel = (int)Mathf.Round(setWord);
        batteryText.SetText(batteryLevel.ToString());

        batteryUI.SetText(batteryLevel.ToString());

    }
}
