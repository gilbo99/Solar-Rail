using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarManager : MonoBehaviour
{

    public GameObject Solar;
    //public GameObject Solar2;
    //public GameObject Solar3;
    public GameObject battery;
    public bool toggle = true;
    public int Randomrotate;
    public float Rotationx;
    public float BatteryCharge;
    public GameObject Sun;

    public void Start()
    {
        ToggleSolarGame();
        EventBus.Current.SolarPanelToggle += ToggleSolarGame;

    }
    void Update()
    {
        if (Rotationx < Randomrotate - 10f & Rotationx > Randomrotate - 30f & toggle)
        {
            Sun.SetActive(true);
            BatteryCharge += Time.deltaTime * 10;
            if(BatteryCharge > 100) 
            {
                BatteryCharge = 100;
            }

            battery.gameObject.GetComponent<Battery>().Charge(BatteryCharge);

        }else
        {
            Sun.SetActive(false);
        }



        if(BatteryCharge > 30)
        BatteryCharge -= Time.deltaTime;
        battery.gameObject.GetComponent<Battery>().Charge(BatteryCharge);

    }
    void ToggleSolarGame()
    {
        toggle = !toggle;
        //Solar.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
        Solar.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;
        //Solar2.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
       // Solar2.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;
        //Solar3.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
       // Solar3.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;

        Randomrotate = Random.Range(-40, -120);
        


    }

    public void SetRotationx(float receivedRotationx)
    {

        if(Rotationx != receivedRotationx)
        Rotationx = receivedRotationx;
        




    }



    void OnDestroy()
    {
        EventBus.Current.SolarPanelToggle -= ToggleSolarGame;
    }



}
