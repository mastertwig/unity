using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float maxSpeed = 5f;
    public float rotSpeed = 180f;

    void Start()
    {

    }

    void Update()
    {

        // ROTATE the ship.

        // Grab our rotation quaternion
        Quaternion rot = transform.rotation;

        // Grab the y euler angle
        float y = rot.eulerAngles.y;

        // Change the Z angle based on input
        y += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        // Recreate the quaternion
        rot = Quaternion.Euler(0, y, 0);

        // Feed the quaternion into our rotation
        transform.rotation = rot;

        // MOVE the ship.
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, 0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime);

        pos += rot * velocity;

        // Finally, update our position!!
        transform.position = pos;

    }
    }
