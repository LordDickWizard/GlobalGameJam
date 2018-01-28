using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {
    public GameObject target;
    float cameraHeight = 0.75f;

    float time;
    float camY;
    float turningSpeed = 5;

    //public GameObject player;
    //public float cameraHeight = 20.0f;

    //void Update()
    //{
    //    Vector3 pos = player.transform.position;
    //    pos.z += cameraHeight;
    //    transform.position = pos;
    //    }

    void Start ()
    {
        
    }

    void Update()
    {
        
    }

    void LateUpdate()
    {


        time = Time.deltaTime;
        if (Input.GetAxis("RightJoystickY") < -0.15 || Input.GetAxis("RightJoystickY") > 0.15)
        {
            camY = Input.GetAxis("RightJoystickY") * turningSpeed * Time.deltaTime;
        }
        else
        {
            camY = 0;
        }
        if (camY != 0)
        {

            //transform.RotateAround(target.transform.position, transform.up, time * camY * turningSpeed);

        }



        //Vector3 pos = target.transform.position;


        //Vector3 offset;
        //offset = Quaternion.AngleAxis(180, target.transform.up) * pos;
        //offset.y += cameraHeight;
        ////pos.z += cameraHeight;
        //transform.position = pos + offset;
        transform.RotateAround(target.transform.position, transform.up, time * camY * turningSpeed);
    }
}
