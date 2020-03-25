using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject prefab2;
    public GameObject prefab;
    void OnCollisionEnter2D(Collision2D col)
    {
        // Put points/ end of game

        if (col.gameObject.tag == "ground")
        {
            Destroy(prefab2);
            Vector3 xyz = transform.position;
            xyz.y -= 0.25f;
            GameObject explosion = Instantiate(prefab, xyz, Quaternion.identity);
          
            
        }



    }
   
}
