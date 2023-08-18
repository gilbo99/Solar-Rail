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

    private bool ableToMove = false;

    public float xSpeed = 0;
    public float zSpeed = 0;

    private bool waterStatus;

    public Transform cube;
    public float speed;
        
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.GreenHouseMinigame += ToggleWater;
    }

    // Update is called once per frame
    void Update()
    {

        if(ableToMove)
        {

        
        if (Input.GetKey("d"))
        {
            cube.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            cube.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            cube.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            cube.Translate(Vector3.down * speed * Time.deltaTime);
        }
        }
    
    }



    public void ToggleWater()
    {
        ableToMove =! ableToMove;
        waterStream.SetActive(ableToMove);
    }

    public void OnDestroy()
    {
        EventBus.Current.GreenHouseMinigame -= ToggleWater;
    }
}
