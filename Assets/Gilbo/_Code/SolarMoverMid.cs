using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarMoverMid : MonoBehaviour
{
    public int rotateSpeed = 10;

    // Update is called once per frame
    void Update()
    {       
        if(Input.GetKey("d"))
        transform.Rotate(0 ,0 ,rotateSpeed * Time.deltaTime);
        if(Input.GetKey("a"))
        transform.Rotate(0 ,0 ,-rotateSpeed * Time.deltaTime);
    }
}
