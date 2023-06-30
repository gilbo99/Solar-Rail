using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerCellsManager : MonoBehaviour
{
    public GameObject powerCell1;
    public GameObject powerCell2;
    public GameObject powerCell3;
    public GameObject powerCell4;

    // Start is called before the first frame update
    void Start()
    {
       EventBus.Current.PowerCellsToggle += Test;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void Test()
    {

    }


    void OnDestroy()
    {
        EventBus.Current.PowerCellsToggle -= Test;
    }
}
