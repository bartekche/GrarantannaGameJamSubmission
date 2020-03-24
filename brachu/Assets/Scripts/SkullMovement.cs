using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMovement : MonoBehaviour
{
    public float velocity = -0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = transform.position;
        p.x -= velocity;
        transform.position = p;

    }
}
