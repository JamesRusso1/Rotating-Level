using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //move left or right
        float x = (Input.GetAxis("Horizontal") * speed);
        transform.position += new Vector3(x * Time.deltaTime, 0f, 0f);
    }
}
