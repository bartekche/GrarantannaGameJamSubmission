using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class DelayButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    WaitForSecondsRealtime _wait;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = 1.0f;
        _wait = new WaitForSecondsRealtime(3f);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        go.SetActive(false);
        yield return _wait;
        print("AA");
        audioSource.Play();
        go.SetActive(true);
    }
}
