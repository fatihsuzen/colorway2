using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MaterialMovement : MonoBehaviour
{
    float z;
    private bool istouchground = false;
    public static float speed = 80f;
    // Start is called before the first frame update
    void Start()
    {
        z = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (istouchground == true)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, z);
            z -= speed*Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        istouchground = true;
    }
}
