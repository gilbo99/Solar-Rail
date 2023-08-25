using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greenhouse : MonoBehaviour
{
    public List<float> planterboxWaterLevels;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FetchPlanterStatus(int planterboxID, float waterLevel)
    {
        planterboxWaterLevels[planterboxID] = waterLevel;
    }

    public void PrimePlanters()
    {
        planterboxWaterLevels.Add(0);
    }

    

    // IF WATER ON ALL INDEX >50 WIN


    // IF ANY WATER >100 LOSE

}
