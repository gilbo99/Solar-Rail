using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarMovertop : MonoBehaviour
{
    public float rotateSpeed;
    public float max = -30;
    public float min = 150;
    
    // Update is called once per frame
    private Quaternion camRotation;
    void Start()
    {
        camRotation = transform.localRotation;
    }
    void Update()
    {     
        //Movement
        if(Input.GetKey("s"))
            camRotation.x += rotateSpeed;
        
        if(Input.GetKey("w"))
            camRotation.x -= rotateSpeed;
        
         //Makes it that the Solar panel cant go past a certain Z/X
        if(camRotation.z > -35)
            camRotation.x -= rotateSpeed;
        
        if(camRotation.z < -140)
            camRotation.x += rotateSpeed;

        //makes it move
        camRotation.z = Mathf.Clamp(camRotation.x, min, max);
        transform.localRotation = Quaternion.Euler(0,  0, camRotation.z);
        // Shows the X rotation for the solar panel
        //Debug.Log(camRotation.x);
    }
}
