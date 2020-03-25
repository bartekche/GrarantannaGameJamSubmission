using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SlowMoMusicController : MonoBehaviour
{
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (SlowMotion.slow)
        {
            audioSource.pitch = 0.5f;
        }
        else
        {
            audioSource.pitch = 1.0f;
        }
    }
}
