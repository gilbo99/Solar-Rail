using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SolarManager : MonoBehaviour
{

    public GameObject solar;
    public GameObject solar2;
    public GameObject solar3;
    public GameObject sunRotate;
    public GameObject battery;
    public GameObject batteryText;
    public GameObject sun_Charging;
    public GameObject sun_NotCharging;
    public GameObject UIManager;

    private bool toggle = true;
    private bool facingSun;
    private int randomrotate;
    public float timer;
    public float setTimer;
    private float Rotationx;
    public float BatteryCharge;
  
    public Color32 color;

    public List<string> objective;
    public List<string> keys;





    private UIManager uiUpdate;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        EventBus.Current.SolarPanelToggle += ToggleSolarGame;
        uiUpdate = UIManager.GetComponent<UIManager>();
        ToggleSolarGame();
        SetSunRotate();

    }
    private void Update()
    {
        if (Rotationx < randomrotate - 10f && Rotationx > randomrotate - 40f)
        {
            sun_Charging.SetActive(true);
            sun_NotCharging.SetActive(false);
            facingSun = true;
        }else
        {
            facingSun = false;
            sun_Charging.SetActive(false);
            sun_NotCharging.SetActive(true);
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
       

    }

    private void SetSunRotate()
    {
        randomrotate = Random.Range(100, -50);
        sunRotate.gameObject.transform.GetComponent<SunRotate>().RotateSun(randomrotate);
    }


    private void ToggleSolarGame()
    {
        toggle = !toggle;
        solar.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;
        solar2.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;
        solar3.gameObject.transform.GetComponent<SolarMovertop>().enabled = toggle;
        //batteryText.SetActive(toggle);

        

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
        //Chnage so Battery is full charge when this is triggered
        battery.gameObject.GetComponent<Battery>().SetCharge(BatteryCharge);
        return facingSun;
    }




    private void OnDestroy()
    {
        EventBus.Current.SolarPanelToggle -= ToggleSolarGame;
    }



}
