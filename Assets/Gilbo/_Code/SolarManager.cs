using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarManager : MonoBehaviour
{

    public GameObject Solar;
    public GameObject Solar2;
    public GameObject Solar3;
    public bool toggle = false;
    

    void ToggleSolarGame()
    {
        Solar.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
        Solar.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<SolarMovertop>().enabled = toggle;
        Solar2.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
        Solar2.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<SolarMovertop>().enabled = toggle;
        Solar3.gameObject.transform.GetChild(1).GetComponent<SolarMoverMid>().enabled = toggle;
        Solar3.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<SolarMovertop>().enabled = toggle;
    } 
    
    private void Start() 
    {
        ToggleSolarGame();

        
    }


   
}
