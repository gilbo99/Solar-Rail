using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanterBox : MonoBehaviour
{
    public GameObject GreenhouseManager;

    // public GameObject ShowerHead;

    // PLANTER ID FOR GREENHOUSE TO CONNECT TO
    
    public int planterboxID;

    public float waterLevel;
    
    public bool beingWatered;

    public float absorbtion;

    // VARIABLE FOR TRACKING PLANTER INDIVIDUAL WATER

    void Start()
    {
        GreenhouseManager.GetComponent<Greenhouse>().PrimePlanters();
    }


    // Update is called once per frame
    void Update()
    {
        if(beingWatered)
        {
            waterLevel += absorbtion * Time.deltaTime;
        }

        GreenhouseManager.GetComponent<Greenhouse>().FetchPlanterStatus(planterboxID, waterLevel);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Water"))
        {
            beingWatered = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        beingWatered = false;

        if (other.CompareTag("Water"))
        {
           GreenhouseManager.GetComponent<Greenhouse>().FetchPlanterStatus(planterboxID, waterLevel);
        }
    }

    void ToggleBeingWatered(bool showerStatus)
    {
        beingWatered = showerStatus;
    }
}
