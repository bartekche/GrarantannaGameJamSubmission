using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullSpawn : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 2f;
    float nextSpawn;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
     if(Time.time > nextSpawn)
        {
            GameObject skull = Instantiate(prefab, transform.position, Quaternion.identity);
            nextSpawn = Time.time + spawnRate;
        }
        
    }
}
