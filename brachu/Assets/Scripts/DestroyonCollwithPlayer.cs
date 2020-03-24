using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonCollwithPlayer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
	{
		// Put points/ end of game
        
        if(col.gameObject.tag != "ground" && col.gameObject.layer != 9 )
        {
            Destroy(col.gameObject);
        }
        
        
		    
	}
}
