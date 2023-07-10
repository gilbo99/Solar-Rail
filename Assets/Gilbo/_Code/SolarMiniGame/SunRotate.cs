using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{
    public float rotateZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, 0, rotateZ);
    }

    public void RotateSun(float _RotateZ)
    {

        rotateZ = -_RotateZ + 25f;
    }
}
