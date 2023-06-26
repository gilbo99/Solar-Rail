using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class Faceto : MonoBehaviour
{
    public Transform target;

    void Update()
    {

        // Gets XYZ  and sets XZ
        //Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        //transform.LookAt(targetPosition);

        transform.rotation = Quaternion.LookRotation(transform.position - target.transform.position);
    }
}
