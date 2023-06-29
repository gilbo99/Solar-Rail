using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{
    public float RotateZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, 0, RotateZ);
    }

    public void RotateSun(float _RotateZ)
    {
        
        RotateZ = -_RotateZ + 25;
    }
}
