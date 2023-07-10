using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject pickup;
    public GameObject playerInventory;

    private bool isPickup = true;
    public bool playerin;
    // Start is called before the first frame update
    private Inventory inventory;
    public void Start()
    {
        inventory = playerInventory.GetComponent<Inventory>();
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) & playerin & isPickup)
        {
            isPickup = !isPickup;
            inventory.Additems(pickup);
            pickup.SetActive(isPickup);

        }else if(Input.GetKeyDown(KeyCode.F) & playerin & isPickup == false)
        {
            isPickup = !isPickup;
            inventory.RemoveItems(pickup);
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



