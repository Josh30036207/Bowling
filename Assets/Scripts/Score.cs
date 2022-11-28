using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int score = 0;
    public Text text;


    public void Add(int ammount)
    {
        score += ammount;
        UpdateDisplay();
    }

    // Start is called before the first frame update
    void Start()
    {

        score = 0;
        UpdateDisplay();
    }


    // Update is called once per frame
    void UpdateDisplay()
    {
        text.text = "Score " + score;
    }
}
