using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPinRespawn : MonoBehaviour
{
    public GameObject pin;
    public GameObject newPin;
    private Vector3 startPos;

    void Start()
    {
        startPos = pin.transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "pinLeft")
        {
            
        }
    }



    void DestroyGameObject()
    {
        /*Destroy(pin);
        Instantiate(newPin);*/
        pin.transform.position = startPos;
    }

    

    void OnTriggerEnter(Collider other)
    {
        DestroyGameObject();
    }
}
