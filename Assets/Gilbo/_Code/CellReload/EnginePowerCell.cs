using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnginePowerCell : MonoBehaviour
{
    public float speed;
    public bool ative = false;

    private Quaternion camRotation;
    // Start is called before the first frame update
    void Start()
    {
        camRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a")&& ative)
        {
            camRotation.x += speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, camRotation.x);
        }
        if (Input.GetKey("d")&& ative)
        {
            camRotation.x -= speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, camRotation.x);
        }

        if(Input.GetKeyDown("f"))
        {
            ative = !ative;
        }



        if (ative == false)
        {

            camRotation.x += 200 * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, camRotation.x);

        }
        

    }
}
