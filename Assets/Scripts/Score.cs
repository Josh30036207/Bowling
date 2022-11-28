using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int score = 0;
    public Text text;
    public float timer = 300;


    public void Add(int ammount)
    {
        score += ammount;
        UpdateDisplay();
        timer = 300;
    }

    // Start is called before the first frame update
    void Start()
    {

        score = 0;
        UpdateDisplay();
    }


    void Update()
    {
        timer = timer - 1;
        if (timer <= 0) { score = 0; UpdateDisplay(); }
    }

    // Update is called once per frame
    void UpdateDisplay()
    {
        text.text = "Score " + score;
        
    }
}
