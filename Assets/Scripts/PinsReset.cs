using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinsReset : MonoBehaviour
{

    public GameObject lPin;
    public GameObject rPin;
    public GameObject mPin;
    private Vector3 startPosl;
    private Vector3 startPosr;
    private Vector3 startPosm;
    private Quaternion startRotl;
    private Quaternion startRotr;
    private Quaternion startRotm;
    public Rigidbody lRb;
    public Rigidbody rRb;
    public Rigidbody mRb;
    // Start is called before the first frame update
    void Start()
    {
        startPosl = lPin.transform.position;
        startRotl = lPin.transform.rotation;
        lRb = lPin.GetComponent<Rigidbody>();

        startPosr = rPin.transform.position;
        startRotr = lPin.transform.rotation;
        rRb = rPin.GetComponent<Rigidbody>();

        startPosm = mPin.transform.position;
        startRotm = lPin.transform.rotation;
        mRb = mPin.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        lPin.transform.rotation = startRotl;
        lPin.transform.position = startPosl;
        
        lRb.velocity = new Vector3(0, 0, 0);

        rPin.transform.rotation = startRotr;
        rPin.transform.position = startPosr;
       
        rRb.velocity = new Vector3(0, 0, 0);

        mPin.transform.rotation = startRotm;
        mPin.transform.position = startPosm;
        
        mRb.velocity = new Vector3(0, 0, 0);
    }
}
