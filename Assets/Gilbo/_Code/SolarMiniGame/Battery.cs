using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Battery : MonoBehaviour
{

    public float batteryCharge;
    public TMP_Text batteryText;
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
        batteryText.SetText(batteryCharge.ToString());
    }
}
