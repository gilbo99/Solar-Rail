using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamrea : MonoBehaviour
{
    public Transform cameraPositon;
    // Update is called once per frame
    private void Update()
    {
        transform.position = cameraPositon.position;
    }
}
