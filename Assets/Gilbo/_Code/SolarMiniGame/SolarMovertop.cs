using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarMovertop : MonoBehaviour
{
    public float rotateSpeed;
    public float maxRotation = -30;
    public float minRotation = -150;
    public float BatteryCharge;
    public int RandomNumber;
    public float RotationX;
    public GameObject gameM;
    //public GameObject Sun;
    
    //int Count;


    // Update is called once per frame
    private Quaternion camRotation;
    void Start()
    {
        camRotation = transform.localRotation;
        

    }
    

    void Update()
    {

        //Movement
        if (Input.GetKey("a"))
        {
            camRotation.x += rotateSpeed;
            print("A");
        }

        if (Input.GetKey("d"))
        {
            camRotation.x -= rotateSpeed;
            print("d");
        }
/*
            //Makes it that the Solar panel cant go past a certain Z/X
            if (camRotation.z > maxRotation - 5)
                camRotation.x -= rotateSpeed;
                RotationX = camRotation.x;
                gameM.GetComponent<SolarManager>().SetRotationx(RotationX);

            if (camRotation.z < minRotation + 5)
                camRotation.x += rotateSpeed;
         */
            //makes it move
            camRotation.x = Mathf.Clamp(camRotation.z, minRotation, maxRotation);
            transform.localRotation = Quaternion.Euler(camRotation.x, 0, 0);
        // Shows the X rotation for the solar panel
        //




        // spawns sun and moves it


        // Sun.transform.position = new Vector3(0, 0, 2);





       // print(Sun.transform.position);



    }

    

    /*
    void FixedUpdate()
    {
        
        if (Count > 15)
        {
            Debug.Log(camRotation.x);
            SolarAngle = camRotation.x;
            Count = 0;
        }
        Count++;
        print(Count);


    }

    */




}
