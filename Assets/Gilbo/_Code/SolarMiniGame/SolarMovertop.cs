using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarMovertop : MonoBehaviour
{
    public float rotateSpeed;
    public float maxRotation = -30;
    public float minRotation = -150;
    public float rotationX;
    public GameObject gameM;

    private Quaternion camRotation;
    // Start is called before the first frame update
    void Start()
    {
        camRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        

    }



    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            camRotation.x += rotateSpeed;
            rotationX = camRotation.x;
            gameM.GetComponent<SolarManager>().SetRotationx(rotationX);
        }

        if (Input.GetKey("d"))
        {
            camRotation.x -= rotateSpeed;
            rotationX = camRotation.x;
            gameM.GetComponent<SolarManager>().SetRotationx(rotationX);
        }


        camRotation.x = Mathf.Clamp(camRotation.x, minRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(camRotation.x, 0, 0);
    }
}