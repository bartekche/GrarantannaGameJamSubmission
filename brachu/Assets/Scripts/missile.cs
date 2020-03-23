using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
	{
		// Put a particle effect here
		Destroy(gameObject);
	}
}

