﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool playaudio = true;
    public static bool jumping = false;
    public static bool crouching = false;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") *runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            if(playaudio)
            {
                audioSource.Play();
            }
            playaudio = false;
            jump = true;
            jumping = true;
            animator.SetBool("jump", true);
        }
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            crouching = true;
            animator.SetBool("crouch", true);

        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            crouching = false;
            animator.SetBool("crouch", false);
        }
        
    }
    public void onLanding()
    {
        print("bbb");
        animator.SetBool("jump", false);
        playaudio = true;
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,crouch,jump);
        jump = false;
        jumping = false;
    }
}

