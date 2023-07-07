using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCellMover : MonoBehaviour
{
    public int PowerCellSegment = 0;
    public List<float> cellCharge;
    public GameObject sliderUI;
    public float BatteryCharge;
    public float randomCharge;
    public float confirmedPowerCellCharge;




    private Quaternion camRotation;

    void Start()
    {
        camRotation = transform.localRotation;
        camRotation.x = 90f;
        randomCharge = Random.Range(10, 50);
    }
 
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("d"))
        {
            camRotation.x += 60f;
            PowerCellRotation(1);
            BatteryCharge = cellCharge[PowerCellSegment];
            transform.localRotation = Quaternion.Euler(camRotation.x, 0, -90);
            randomCharge = Random.Range(10, 50);
            
        }

        if (Input.GetKeyDown("a"))
        {
            camRotation.x -= 60f;
            PowerCellRotation(-1);
            BatteryCharge = cellCharge[PowerCellSegment];
            transform.localRotation = Quaternion.Euler(camRotation.x, 0, -90);

            
        }

        
        
        if (Input.GetKey("w"))
        {

            BatteryCharge += Time.deltaTime * randomCharge;
            if (BatteryCharge > 100)
            {
              
            }


            cellCharge[PowerCellSegment] =+ BatteryCharge;

            sliderUI.GetComponent<UIManager>().BatterySlider(BatteryCharge, PowerCellSegment);
        }

        if(Input.GetKey("space"))
        {
            /*
            for (i = < 7, i = 0, i++)
            {
                confirmedPowerCellCharge + cellCharge[i];
            }
            */
        }

        
       
  
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




