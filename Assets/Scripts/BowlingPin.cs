using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPin : MonoBehaviour
{

    public Transform pin;
    public float threshold = 0.00006f;
    public int point = 1;
    public Score score;

    void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>(); 
    }

    void CheckItFell()
    {
        try {
            if (pin.up.y <= threshold)
            {
                score.Add(point);
                gameObject.GetComponent<Collider>().enabled = false;
            }
        }

        catch {
            Debug.Log("Pin entered the dead zone");
        }

    }

    void OnTriggerEnter(Collider other)
    {
        CheckItFell();
        //score.Add(point);
       // gameObject.GetComponent<Collider>().enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
