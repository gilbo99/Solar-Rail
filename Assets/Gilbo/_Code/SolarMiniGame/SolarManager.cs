using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SolarManager : MonoBehaviour
{

    public GameObject Solar;
    public GameObject Solar2;
    public GameObject Solar3;
    public GameObject sunRotate;
    public GameObject battery;
    public GameObject batteryText;
    public GameObject Sun;
    public GameObject UIManager;

    private bool toggle = true;
    private bool facingSun;
    private int Randomrotate;
    private float timer;
    public float setTimer;
    private float Rotationx;
    public float BatteryCharge;
  
    public Color32 color;

    public List<string> objective;
    public List<string> keys;





    private UIManager uiUpdate;

    public void Start()
    {

        uiUpdate = UIManager.GetComponent<UIManager>();
        ToggleSolarGame();
        EventBus.Current.SolarPanelToggle += ToggleSolarGame;
        SetSunRotate();

    }
    void Update()
    {
        if (Rotationx < Randomrotate - 10f & Rotationx > Randomrotate - 30f)
        {
            Sun.SetActive(true);
            facingSun = true;

            

        }else
        {
            facingSun = false;
            Sun.SetActive(false);
        }


        
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                SetSunRotate();
                timer = setTimer;
            }
        



        /*
        if(BatteryCharge > 30)
        BatteryCharge -= Time.deltaTime;
        battery.gameObject.GetComponent<Battery>().Charge(BatteryCharge);
        */

    }

    private void SetSunRotate()
    {
        Randomrotate = Random.Range(50, -50);
        sunRotate.gameObject.transform.GetComponent<SunRotate>().RotateSun(Randomrotate);
    }


    void ToggleSolarGame()
    {
        toggle = !toggle;
        Solar.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;
        Solar2.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;
        Solar3.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;
        batteryText.SetActive(toggle);

        

        if (toggle)
        {
            uiUpdate.ObjectiveUpdate(objective[0], objective[1], objective[2] , objective[3]);
            uiUpdate.ButtonUpdate(keys[0], keys[1], keys[2]);
            uiUpdate.borderChange(color);
        }
        else
        {
            Color32 setInvis = new Color32(225, 255, 0, 0);
            uiUpdate.ObjectiveUpdate("", "", "", "");
            uiUpdate.ButtonUpdate("","","");
            uiUpdate.borderChange(setInvis);

        }



    }

    public void SetRotationx(float receivedRotationx)
    {

        if(Rotationx != receivedRotationx)
        Rotationx = receivedRotationx;
        

    }

    public bool AbletoCharge(float val)
    {
        BatteryCharge = val;
        battery.gameObject.GetComponent<Battery>().Charge(BatteryCharge);
        return facingSun;
    }




    void OnDestroy()
    {
        EventBus.Current.SolarPanelToggle -= ToggleSolarGame;
    }



}
