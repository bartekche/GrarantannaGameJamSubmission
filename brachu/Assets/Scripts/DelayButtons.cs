using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    WaitForSecondsRealtime _wait;
    void Start()
    {
        _wait = new WaitForSecondsRealtime(3f);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        go.SetActive(false);
        yield return _wait;
        print("AA");
        go.SetActive(true);
    }
}
