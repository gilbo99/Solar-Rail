using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCueb : MonoBehaviour
{
    public Transform cube;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
            cube.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if(Input.GetKey("d"))
        {
            cube.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
