using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarMovertop : MonoBehaviour
{
    public float rotateSpeed = 0.5f;
    public float maxRotation = -30;
    public float minRotation = -150;
    public float RotationX;
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
        if (Input.GetKey("a"))
        {
            camRotation.x += rotateSpeed;
            print("a");
            RotationX = camRotation.x;
            gameM.GetComponent<SolarManager>().SetRotationx(RotationX);
        }

        if (Input.GetKey("d"))
        {
            camRotation.x -= rotateSpeed;
            print("D");
            RotationX = camRotation.x;
            gameM.GetComponent<SolarManager>().SetRotationx(RotationX);
        }


        camRotation.x = Mathf.Clamp(camRotation.x, minRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(camRotation.x, 0, 0);

    }
}