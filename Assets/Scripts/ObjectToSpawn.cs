using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToSpawn : MonoBehaviour
{

    public GameObject hBall;
    public GameObject sBall;
    public GameObject lBall;
    private Vector3 startPosH;
    private Vector3 startPosS;
    private Vector3 startPosL;
    public Rigidbody hRb;
    public Rigidbody sRb;
    public Rigidbody lRb;
    // Start is called before the first frame update
    void Start()
    {
        startPosH = hBall.transform.position;
        hRb = hBall.GetComponent<Rigidbody>();

        startPosS = sBall.transform.position;
        sRb = sBall.GetComponent<Rigidbody>();

        startPosL = lBall.transform.position;
        lRb = lBall.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        hBall.transform.position = startPosH;
        hRb.velocity = new Vector3(0, 0, 0);

        sBall.transform.position = startPosS;
        sRb.velocity = new Vector3(0, 0, 0);

        lBall.transform.position = startPosL;
        lRb.velocity = new Vector3(0, 0, 0);
    }
}
