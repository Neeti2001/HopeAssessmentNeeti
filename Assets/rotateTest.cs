using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTest : MonoBehaviour
{
    float xSpeed = 0.0f;
    float ySpeed = 0.0f;
    float zSpeed = 0.0f;
    bool rotateMe = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rotateMe)
        {
            ySpeed = 40f;
        }
        else
        {
            ySpeed = 0f;
        }

        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
    }

    public void ChangeBool()
    {
        rotateMe = !rotateMe;
    }
}
