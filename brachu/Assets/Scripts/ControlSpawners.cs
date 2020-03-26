using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSpawners : MonoBehaviour
{
    // Start is called before the first frame update
    WaitForSecondsRealtime _wait;
    public GameObject sup;
    public GameObject sleft;
    public GameObject sright;
    float Startingtime;
    float currentTime;
    float d;
    void Start()
    {
        Startingtime = Time.time;
        _wait = new WaitForSecondsRealtime(0.5f);
        sup.SetActive(false); sleft.SetActive(false); sright.SetActive(false);
        sleft.GetComponent<SkullSpawn>().prefab.GetComponent<SkullMovement>().velocity = -6; sright.GetComponent<SkullSpawn>().prefab.GetComponent<SkullMovement>().velocity = 6;
        StartCoroutine(Example());

    }

    IEnumerator Example()
    {
        while(true)
        {
            currentTime = Time.time - Startingtime;
            d = Map(currentTime);

            sleft.GetComponent<SkullSpawn>().spawnRate = Random.Range(4.5f-d, 5.5f-d);
            sright.GetComponent<SkullSpawn>().spawnRate = Random.Range(3.5f - d, 4.0f - d);
            sup.GetComponent<UpSpawn>().spawnRate = Random.Range(4.5f - d, 5.0f - d);
            sup.GetComponent<UpSpawn>().spawnRate2 = Random.Range(3.5f - d, 4.0f - d);
            sup.GetComponent<UpSpawn>().spawnRate3 = Random.Range(3.5f - d, 4.0f - d);

            sleft.GetComponent<SkullSpawn>().prefab.GetComponent<SkullMovement>().velocity = -5.0f-d*2; sright.GetComponent<SkullSpawn>().prefab.GetComponent<SkullMovement>().velocity = 4.0f + d*1.5f;

            sup.SetActive(true); 
            yield return _wait;
            sleft.SetActive(true);
            yield return _wait;
            sright.SetActive(true);
        }
        
    }
    float Map(float x){
    if(x>50.0f)
        {
            return 3.0f;
        }
     return Mathf.Sin(x/50.0f * Mathf.PI / 2.0f)*3.0f;
 }

}
