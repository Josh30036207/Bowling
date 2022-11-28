using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltPinReset : MonoBehaviour
{

    
    public GameObject LPin;
    public GameObject LPin2;

    private Vector3 startPosH;
    private Vector3 startPosS;
    private Vector3 startPosL;
    // Start is called before the first frame update
    void Start()
    {
        this.LPin.transform.position = new Vector3(40, 2, -52);

        Instantiate(LPin);
        startPosL = LPin.transform.position;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        DestroyImmediate(LPin, true);
        LPin.transform.position = new Vector3(0, -100, 0);
        LPin.transform.position = startPosL;
        Instantiate(LPin);
    }
}
