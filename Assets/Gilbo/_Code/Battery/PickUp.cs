using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject pickup;

    private bool isPickup = true;
    public bool playerin;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) & playerin)
        {
            isPickup = !isPickup;
            pickup.SetActive(isPickup);
        }
    }



   

    public void OnTriggerEnter(Collider other)
    {
        playerin = true;


    }

    public void OnTriggerExit(Collider other)
    {
        playerin = false;
    }
}



