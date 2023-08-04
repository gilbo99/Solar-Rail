using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerCellMover : MonoBehaviour
{
    private int powerCellSegment = 0;
    private int winCount;
    public int checkWithin; 

    public float batteryCharge;
    public float randomCharge;
    public float confirmedPowerCellCharge;
    public float RandomCellChargeF;
    public float batteryChargeCheck;
    

    public List<float> cellCharge;
    public List<float> RandomCellCharge;

    public GameObject sliderUI;
    public GameObject SolarManager;

    private bool facingsun;

    private Quaternion camRotation;
    
    void Start()
    {
        
        camRotation = transform.localRotation;
        camRotation.x = 90f;
        randomCharge = Random.Range(10, 50);



        for(int i = 0; i < RandomCellCharge.Count; i++)
        {
            RandomCellCharge[i] = Random.Range(25, 90);
            sliderUI.GetComponent<UIManager>().RandomBatterySlider(RandomCellCharge[i], i);
        }


    }
    public void OnEnable()
    {
        facingsun = SolarManager.GetComponent<SolarManager>().AbletoCharge(confirmedPowerCellCharge);
    }

    // Update is called once per frame
    void Update()
    {

        if (facingsun)
        {
            if (Input.GetKeyDown("d"))
            {
                camRotation.x += 60f;
                PowerCellRotation(1);
                batteryCharge = cellCharge[powerCellSegment];
                transform.localRotation = Quaternion.Euler(camRotation.x, -90, -90);
                randomCharge = Random.Range(30, 60);


              


            }

            if (Input.GetKeyDown("a"))
            {
                camRotation.x -= 60f;
                PowerCellRotation(-1);
                batteryCharge = cellCharge[powerCellSegment];
                transform.localRotation = Quaternion.Euler(camRotation.x, -90, -90);
                randomCharge = Random.Range(30, 60);


            }



            if (Input.GetKey("w"))
            {

                batteryCharge += Time.deltaTime * randomCharge;
                if (batteryCharge > 100)
                {
                    batteryCharge = 100; 
                }


                cellCharge[powerCellSegment] = +batteryCharge;

                sliderUI.GetComponent<UIManager>().BatterySlider(batteryCharge, powerCellSegment);
            }

            if (Input.GetKeyDown("space"))
            {
                CheckIfCharged();
                for (int i = 0; i < cellCharge.Count; i++)
                {
                    confirmedPowerCellCharge += cellCharge[i];
                    cellCharge[i] = 0;
                    batteryCharge = 0;
                    sliderUI.GetComponent<UIManager>().BatterySlider(0, i);
                }

                facingsun = SolarManager.GetComponent<SolarManager>().AbletoCharge(confirmedPowerCellCharge);




                

            }


        }
  
    }

    void PowerCellRotation(int listadd)
    {


        powerCellSegment += listadd;


        if(powerCellSegment == 6)
        {
            powerCellSegment = 0;
        }
        if (powerCellSegment == -1)
        {
            powerCellSegment = 5;
        }

    }

    void CheckIfCharged()   
    {
        for(int i = 0; i < RandomCellCharge.Count; i++)
        {
            batteryChargeCheck = cellCharge[i];
            RandomCellChargeF = RandomCellCharge[i];
            if(RandomCellChargeF + checkWithin > batteryChargeCheck && RandomCellChargeF - checkWithin < batteryChargeCheck)
            {
                winCount++;
                if(winCount == 6)
                {
                    Debug.Log("Send Finish gmae");
                    //SceneManager.LoadSceneAsync("Water Nutrients");
                }
            }
        }
    }


     

    
    






}




