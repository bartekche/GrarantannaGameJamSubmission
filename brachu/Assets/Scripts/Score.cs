﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    Text scoretext;
    float  Startingtime;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoretext = GetComponent<Text>();
        Startingtime= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        score = Mathf.RoundToInt((Time.time- Startingtime) * 10);
        scoretext.text = score.ToString();

    }
}
