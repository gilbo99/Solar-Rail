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
        if(Input.GetKeyDown("p"))
        {
            CheckWaterLevels();
        }
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

    void CheckWaterLevels()
    {
        for (int i = 0; i < planterboxWaterLevels.Count; i++) 
        {
            switch(planterboxWaterLevels[i])
            {
                case <30:
                    print("Planter Box #" + i+1 + " doesn't have enough.");
                    // DECLARE LOSS "You could have done better."
                    break;
                case < 100:
                    print("Planter Box #" + i+1 + " has enough water.");
                    // DECLARE WIN
                    break;
                case >100:
                    print("Planter Box #" + i+1 + " has too much water.");
                    // DECLARE LOSS SEND TO LOSS SCREEN
                    break;
            }
        }   
        
        print("All Planter Boxes have been assessed.");
    }
}
