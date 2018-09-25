using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationColor : MonoBehaviour
{

    float smooth = 0.6f;



    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        

        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0, 180, 0);
            smooth = 3f;
        }

        Quaternion target = Quaternion.Euler(180, 0, 0);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
