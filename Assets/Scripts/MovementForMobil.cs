using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForMobil : MonoBehaviour
{
    private Touch touch;
    private float speed = 0.01f;
    void Update()
    {

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z);
            }

        }
    }
}
