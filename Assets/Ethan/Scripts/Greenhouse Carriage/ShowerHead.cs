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

    public float xSpeed = 0;
    public float zSpeed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        showerHead.velocity = new Vector3(rigidbody.velocity.x + xSpeed, rigidbody.velocity.y, rigidbody.velocity.z + zSpeed);
        
        // TURN ON WATER
        if(Input.GetKeyDown("space"))
        {
            waterStream.SetActive(true);
        }

        if(Input.GetKeyUp("space"))
        {
            waterStream.SetActive(false);
        }
        
        // MOVE SHOWER HEAD / DOWN
        if(Input.GetKeyDown("w"))
        {
            if(upAllowed)
            {
                zSpeed = 1;
                print("moving up");
            } 
        } else {
            zSpeed = 0;
        }

        if(Input.GetKeyDown("s"))
        {
            if(upAllowed)
            {
                zSpeed = -1;
                print("moving up");
            } 
        } else {
            zSpeed = 0;
        }
    }
}
