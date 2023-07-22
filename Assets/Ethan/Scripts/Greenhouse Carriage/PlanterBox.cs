using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanterBox : MonoBehaviour
{
    public GameObject GreenhouseManager;

    // PLANTER ID FOR GREENHOUSE TO CONNECT TO
    
    public int planterboxID;

    public float waterLevel;
    
    private bool beingWatered;

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
            waterLevel += Time.deltaTime * 1;
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
        if(other.CompareTag("Water"))
        {
           GreenhouseManager.GetComponent<Greenhouse>().FetchPlanterStatus(planterboxID, waterLevel);
           beingWatered = false;
        }
    }
}
