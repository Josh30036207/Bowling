using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test : MonoBehaviour
{
    public float score = 0;
    public Text text;
    public float timer = 300;


    JoyconDemo control;

    // Start is called before the first frame update
    void Start()
    {

        //score = 0;
        UpdateDisplay();
    }

    void Update()
    {
        score = control.getForce();

        UpdateDisplay();

    }


    // Update is called once per frame
    void UpdateDisplay()
    {
        text.text = "test " + score;

    }
}
