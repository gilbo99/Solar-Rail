using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCellMover : MonoBehaviour
{
    public int PowerCellSegment = 0;
    public List<float> CellCharge;

    public float BatteryCharge;



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
            PowerCellRotation(1);
            BatteryCharge = CellCharge[PowerCellSegment];
        }

        if (Input.GetKeyDown("a"))
        {
            camRotation.x -= 60f;
            PowerCellRotation(-1);
            BatteryCharge = CellCharge[PowerCellSegment];

        }

        if (Input.GetKey("w"))
        {

            BatteryCharge += Time.deltaTime * 10;
            if (BatteryCharge > 100)
            {
                Destroy(gameObject);
            }


            CellCharge[PowerCellSegment] =+ BatteryCharge;
        }

        
        transform.localRotation = Quaternion.Euler(camRotation.x, 0, -90);
  
    }

    void PowerCellRotation(int listadd)
    {


        PowerCellSegment += listadd;


        if(PowerCellSegment == 6)
        {
            PowerCellSegment = 0;
        }
        if (PowerCellSegment == -1)
        {
            PowerCellSegment = 5;
        }


    }

    




}




