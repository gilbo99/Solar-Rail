using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBattery : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        UIUpdater.GetComponent<UpdateUIInteract>().UpdateUIText("Press F To Start " + MiniGame);
    }
}
