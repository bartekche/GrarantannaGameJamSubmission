using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHighScore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    void Start()
    {
        text.SetActive(false);
        if(HighScore.newhighscore==true)
        {
            text.SetActive(true);
        }
    }

}
