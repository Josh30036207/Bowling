using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltReset : MonoBehaviour
{

    public GameObject Pin1;
    public GameObject Pin2;
    public GameObject Pin3;
    public GameObject Pin4;
    public GameObject Pin5;
    public GameObject Pin6;
    public GameObject Pin7;
    public GameObject Pin8;
    public GameObject Pin9;
    public GameObject Pin0;

    private Vector3 startPos1;
    private Vector3 startPos2;
    private Vector3 startPos3;
    private Vector3 startPos4;
    private Vector3 startPos5;
    private Vector3 startPos6;
    private Vector3 startPos7;
    private Vector3 startPos8;
    private Vector3 startPos9;
    private Vector3 startPos0;

    private Quaternion startRot1;
    private Quaternion startRot2;
    private Quaternion startRot3;
    private Quaternion startRot4;
    private Quaternion startRot5;
    private Quaternion startRot6;
    private Quaternion startRot7;
    private Quaternion startRot8;
    private Quaternion startRot9;
    private Quaternion startRot0;

    public Rigidbody Rb1;
    public Rigidbody Rb2;
    public Rigidbody Rb3;
    public Rigidbody Rb4;
    public Rigidbody Rb5;
    public Rigidbody Rb6;
    public Rigidbody Rb7;
    public Rigidbody Rb8;
    public Rigidbody Rb9;
    public Rigidbody Rb0;

    // Start is called before the first frame update
    void Start()
    {
        startPos1 = Pin1.transform.position;
        startPos2 = Pin2.transform.position;
        startPos3 = Pin3.transform.position;
        startPos4 = Pin4.transform.position;
        startPos5 = Pin5.transform.position;
        startPos6 = Pin6.transform.position;
        startPos7 = Pin7.transform.position;
        startPos8 = Pin8.transform.position;
        startPos9 = Pin9.transform.position;
        startPos0 = Pin0.transform.position;

        startRot1 = Pin1.transform.rotation;
        startRot2 = Pin2.transform.rotation;
        startRot3 = Pin3.transform.rotation;
        startRot4 = Pin4.transform.rotation;
        startRot5 = Pin5.transform.rotation;
        startRot6 = Pin6.transform.rotation;
        startRot7 = Pin7.transform.rotation;
        startRot8 = Pin8.transform.rotation;
        startRot9 = Pin9.transform.rotation;
        startRot0 = Pin0.transform.rotation;

    }

    void OnTriggerEnter(Collider other)
    {
        Pin1.transform.rotation = startRot1;
        Pin1.transform.position = startPos1;
        Rb1.velocity = new Vector3(0, 0, 0);

        Pin2.transform.rotation = startRot2;
        Pin2.transform.position = startPos2;
        Rb2.velocity = new Vector3(0, 0, 0);

        Pin3.transform.rotation = startRot3;
        Pin3.transform.position = startPos3;
        Rb3.velocity = new Vector3(0, 0, 0);

        Pin4.transform.rotation = startRot4;
        Pin4.transform.position = startPos4;
        Rb4.velocity = new Vector3(0, 0, 0);

        Pin5.transform.rotation = startRot5;
        Pin5.transform.position = startPos5;
        Rb5.velocity = new Vector3(0, 0, 0);

        Pin6.transform.rotation = startRot6;
        Pin6.transform.position = startPos6;
        Rb6.velocity = new Vector3(0, 0, 0);

        Pin7.transform.rotation = startRot7;
        Pin7.transform.position = startPos7;
        Rb7.velocity = new Vector3(0, 0, 0);

        Pin8.transform.rotation = startRot8;
        Pin8.transform.position = startPos8;
        Rb8.velocity = new Vector3(0, 0, 0);

        Pin9.transform.rotation = startRot9;
        Pin9.transform.position = startPos9;
        Rb9.velocity = new Vector3(0, 0, 0);

        Pin0.transform.rotation = startRot0;
        Pin0.transform.position = startPos0;
        Rb0.velocity = new Vector3(0, 0, 0);


    }
}