using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnginePowerCell : MonoBehaviour
{
    public float speed;
    public bool activate = false;

    private Quaternion camRotation;
    // Start is called before the first frame update
    void Start()
    {
        camRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") && activate)
        {
            camRotation.x += speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 90, camRotation.x);
        }
        if (Input.GetKey("d") && activate)
        {
            camRotation.x -= speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 90, camRotation.x);
        }

        if (Input.GetKeyDown("f"))
        {
            activate = !activate;
        }



        if (activate == false)
        {

            camRotation.x += 200 * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 90, camRotation.x);

        }


    }
}