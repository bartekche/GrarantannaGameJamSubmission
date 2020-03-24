using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_missle : MonoBehaviour
{
    // Start is called before the first frame update
    
    void OnCollisionEnter2D(Collision2D collision)
	{
		// Put a particle effect here
		Destroy(collision.gameObject);
	}
}
