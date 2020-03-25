using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    private float slowmo = 0.1f;
    private float normaltime = 1.0f;
    public static bool slow = false;

    public GameObject player;
    private Rigidbody2D rb;
    private void Update()
    {
        rb = player.GetComponent<Rigidbody2D>();
        if ( (Mathf.Abs(rb.velocity.x) > 0.01f ) || (Mathf.Abs(rb.velocity.y) > 0.01f) || PlayerMovement.jumping || PlayerMovement.crouching)
        {
            if(slow)
            {
                Time.timeScale = normaltime;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                slow = false;
            }
        }
        else
        {
            Time.timeScale = slowmo;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            slow = true;
        }
    }
}
