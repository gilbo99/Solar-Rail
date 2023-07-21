using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerHead : MonoBehaviour
{
    public GameObject showerHead;
    public GameObject waterStream;

    private bool upAllowed;
    private bool downAllowed;
    private bool leftAllowed;
    private bool rightAllowed;

    public float speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TURN ON WATER
        if(Input.GetKeyDown("space"))
        {
            GameObject.waterStream.SetActive(true);
        } else {
            GameObject.waterStream.SetActive(false);
        }
        
        // MOVE SHOWER HEAD / UP
        if(Input.GetKeyDown("w") || Input.GetKeyDown("up"))
        {
            if(upAllowed)
            {
                showerHead.Transform(0, transform.position + speed, 0);
                print("moving up");
            }
        }
    }
}
