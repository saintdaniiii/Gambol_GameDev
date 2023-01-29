using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMovement : MonoBehaviour
{
    float speed = 15f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        Vector2 dir = Vector2.zero;
        dir.x = Input.acceleration.x;
        dir.y = 0;

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        transform.Translate(dir * speed);

    }

    void FixedUpdate()
    {

    }
}
// transform.Translate(Input.acceleration.x * speed * Time.deltaTime, Input.acceleration.y * speed * Time.deltaTime, 0);
