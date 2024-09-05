using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    //change speed in Unity
    public float rotateSpeed;

   
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Left Click to rotate left
            Rotate(-rotateSpeed);
        }


        if (Input.GetMouseButton(1))
        {
            //Right Click to rotate right
            Rotate(rotateSpeed);
        }

    }

    //rotate around the z axis/ center point of 2d object
    void Rotate(float zAngle)
    {
        transform.Rotate(new Vector3(0,0,1) * zAngle * Time.deltaTime);
    }
}
