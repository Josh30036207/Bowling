using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyconDemo : MonoBehaviour
{

    private List<Joycon> joycons;

    // Values made available via Unity
    public float[] stick;
    public Vector3 gyro;
    public Vector3 accel;
    public int jc_ind = 0;
    public Quaternion orientation;

    public float force;
    public Vector3 oldgyro;
    public Vector3 difgyro;

    float throwForce = 6000;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    public float testForce;

    void Start()
    {
        gyro = new Vector3(0, 0, 0);
        accel = new Vector3(0, 0, 0);
        // get the public Joycon array attached to the JoyconManager in scene
        joycons = JoyconManager.Instance.j;

    }

    public float getForce()
    {
        return (force);
    }

    // Update is called once per frame
    void Update()
    {

        oldgyro = gyro;


        // make sure the Joycon only gets checked if attached
        if (joycons.Count > 0)
        {
            Joycon j = joycons[jc_ind];
            // GetButtonDown checks if a button has been pressed (not held)


            // Gyro values: x, y, z axis values (in radians per second)
            gyro = j.GetGyro();



            //checks the difference in positions between ticks, allows to track speed
            difgyro = gyro - oldgyro;
            testForce = (difgyro[0] + difgyro[1] + difgyro[2] * 6000);//sets the force of the bowl... the *6000 is to add some oomth, as code is very crude and doesn't work well. But Its 19:55 and I still got a write up so...








        }
        //code from pickup.cs
        {

            distance = Vector3.Distance(item.transform.position, tempParent.transform.position); //check if within grabbing distance of the player 
            if (distance >= 2f)
            {
                isHolding = false;
            }


            if (isHolding == true)
            {
                item.GetComponent<Rigidbody>().velocity = Vector3.zero;
                item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                item.transform.SetParent(tempParent.transform);


            }
            else
            {
                objectPos = item.transform.position;
                item.transform.SetParent(null);
                item.GetComponent<Rigidbody>().useGravity = true;
                item.transform.position = objectPos;
            }


        }
    }
    void OnMouseDown()
    {
        if (distance <= 2f)
        {
            isHolding = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }

    void OnMouseUp()
    {
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * testForce);
        }
        isHolding = false;


    }
}