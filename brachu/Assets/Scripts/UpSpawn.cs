using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSpawn : MonoBehaviour
{
    public GameObject prefab;
    public GameObject player;
    public float spawnRate = 2f;
    public float spawnRate2 = 2f;
    public float spawnRate3 = 2f;
    float Startingtime;
    float nextSpawn;
    float nextSpawn2;
    float nextSpawn3;
    // Start is called before the first frame update
    // Update is called once per frame

    private void Start()
    {
        Startingtime = Time.time;
        nextSpawn = 1.0f;
        nextSpawn2 = 2.0f;
        nextSpawn3 = 3.0f;

    }
    void Update()
    {
        if (Time.time-Startingtime > nextSpawn)
        {
            Vector3 xyz = transform.position;
            xyz.x = player.transform.position.x + Random.Range(-0.5f, 0.5f);
            GameObject up = Instantiate(prefab, xyz , transform.rotation);
            nextSpawn = Time.time + spawnRate;
        }
        if(Time.time-Startingtime > nextSpawn2)
        {
            Vector3 xyz = transform.position;
            xyz.x = Random.Range(-6.5f, 6.5f);
            GameObject up = Instantiate(prefab, xyz, transform.rotation);
            nextSpawn2 = Time.time + spawnRate2;
        }
        if (Time.time - Startingtime > nextSpawn3)
        {
            Vector3 xyz = transform.position;
            xyz.x = Random.Range(-6.5f, 6.5f);
            GameObject up = Instantiate(prefab, xyz, transform.rotation);
            nextSpawn3 = Time.time + spawnRate3;
        }

    }
}
