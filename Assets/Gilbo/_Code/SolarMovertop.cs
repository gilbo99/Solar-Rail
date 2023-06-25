using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarMovertop : MonoBehaviour
{
    public float rotateSpeed;
    public float maxRotation = -30;
    public float minRotation = -150;
    public float BatteryCharge;
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
                camRotation.x += rotateSpeed;

            if (Input.GetKey("d"))
                camRotation.x -= rotateSpeed;

            //Makes it that the Solar panel cant go past a certain Z/X
            if (camRotation.z > maxRotation - 5)
                camRotation.x -= rotateSpeed;

            if (camRotation.z < minRotation + 5)
                camRotation.x += rotateSpeed;
         
            //makes it move
            camRotation.z = Mathf.Clamp(camRotation.x, minRotation, maxRotation);
            transform.localRotation = Quaternion.Euler(0, 0, camRotation.z);
            // Shows the X rotation for the solar panel
            //
         


        if(camRotation.x < -80 & camRotation.x > -100)
        {
            BatteryCharge += Time.deltaTime * 2;
        }
        
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
