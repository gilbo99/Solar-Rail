using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public List<GameObject> Battery;
    public List<GameObject> ChargedBattery;
    private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f") & entered & Battery.Count <1)
        {
            if (ChargedBattery != null)
            {
                ChargedBattery[0].SetActive(false);
                Battery.Add(ChargedBattery[0]);
                ChargedBattery.RemoveAt(0);


            }

            if (Input.GetKey("d"))
            {
                ChargedBattery.Add(Battery[0]);
                ChargedBattery[0].SetActive(true);
                Battery.RemoveAt(0);

            }



        }


        if (Input.GetKey("i"))
        {
            print("I");
        }

    }

    void OnTriggerEnter(Collider other)
    {
        entered = true;



    }

    void OnTriggerExit(Collider other)
    {
        entered = false;
    }
}
