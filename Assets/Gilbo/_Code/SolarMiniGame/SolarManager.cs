using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarManager : MonoBehaviour
{

    public GameObject Solar;
    public GameObject Solar2;
    public GameObject Solar3;
    public bool toggle = true;
    public int RandomNumber;
    public float Rotationx;
    public float BatteryCharge;

    public void Start()
    {
        ToggleSolarGame();
        EventBus.Current.SolarPanelToggle += ToggleSolarGame;

    }
    void Update()
    {
        if (Rotationx < -80 & Rotationx > -100)
        {
            BatteryCharge += Time.deltaTime * 2;

        }

    }
    void ToggleSolarGame()
    {
        toggle = !toggle;
        //Solar.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
        Solar.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<SolarMovertop>().enabled = toggle;
        //Solar2.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
        Solar2.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<SolarMovertop>().enabled = toggle;
        //Solar3.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
        Solar3.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<SolarMovertop>().enabled = toggle;

        //RandomNumber = Random.Range(-40, -140);
       
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
