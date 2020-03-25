using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class HitSoundController : MonoBehaviour
{
    WaitForSecondsRealtime _wait;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = 1.0f;
        _wait = new WaitForSecondsRealtime(1f);
        StartCoroutine(Example());

    }

    IEnumerator Example()
    {
        audioSource.Play();
        yield return _wait;
        audioSource.Play();
        yield return _wait;
        audioSource.Play();
    }
}
