using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCellMover : MonoBehaviour
{
    public float rotateSpeed = 0.5f;
    public int PowerCellSegment = 1;

    public float CellCharge1;
    public float CellCharge2;
    public float CellCharge3;
    public float CellCharge4;
    public float CellCharge5;
    public float CellCharge6;
    

    private Quaternion camRotation;
    // Start is called before the first frame update
    void Start()
    {

        camRotation = transform.localRotation;

        camRotation.x = 90f;

        
    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("d"))
        {
            camRotation.x += 60f;
        }

        if (Input.GetKeyDown("a"))
        {
            camRotation.x -= 60f;

        }

        if (Input.GetKey("w"))
        {
            
        }

        






        transform.localRotation = Quaternion.Euler(camRotation.x, 0, -90);



    }
    /*
    void PowerCellRotation()
    {
        if (powerCellSegment == 0)
        {
            PowerCellSegment = 0;
        } else
        {
            powerCellSegment++;
        }
    }

    void ChargePowerCellSegment()
    {
        list.PowerCellSegmentLevel[PowerCellSegment] ++ 1;
    }

    //UPDATE

    if(powerCellSegmentLevel[powerCellSegment] > 10)
    {
        // FAILL
    }

   */

       
    

}




