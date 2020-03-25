using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSpawn : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 2f;
    float nextSpawn;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            Vector3 xyz = transform.position;
            xyz.x = Random.Range(-6.5f, 6.5f);
            GameObject up = Instantiate(prefab, xyz , transform.rotation);
            nextSpawn = Time.time + spawnRate;
        }

    }
}
