using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float m_speed = 5;
    public float m_cameraSpeed = 100;
    Vector3 movement;
    float time;
    float camY;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("LeftJoyX"), 0, -Input.GetAxis("LeftJoyY"));

        time = Time.deltaTime;
        if (Input.GetAxis("RightJoystickY") < -0.15 || Input.GetAxis("RightJoystickY") > 0.15)
        {
            camY = Input.GetAxis("RightJoystickY") * m_speed * Time.deltaTime;
        }
        else
        {
            camY = 0;
        }
        if (camY != 0)
        {

            transform.RotateAround(transform.position, transform.up, time * camY * m_speed);

        }

        transform.position = transform.position + Camera.main.transform.forward * movement.z * Time.deltaTime * m_cameraSpeed;
        transform.position = transform.position + Camera.main.transform.right * movement.x * Time.deltaTime * m_cameraSpeed;

        transform.Rotate(transform.up, Time.deltaTime * Input.GetAxis("RightJoystickY") * m_cameraSpeed);
        //transform.position = transform.position - Camera.main.transform.up * Time.deltaTime * speed;


        //Quaternion rotation = new Quaternion(0, movement.x, movement.y, body.GetComponent<Transform>().rotation.w * (0.1f * 3.14f/180));
        //transform.Rotate(transform.up, Time.deltaTime * Input.GetAxis("RightJoystickY") * speed);
        //transform.localRotation(transform.up, Time.deltaTime * speed);
    }


}
