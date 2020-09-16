using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 0.4f;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position = new Vector3(transform.position.x + (h * speed/5), transform.position.y,
           transform.position.z + (v * speed));

        if (Time.time > 5f)
            gameObject.SetActive(true);
    }
}
