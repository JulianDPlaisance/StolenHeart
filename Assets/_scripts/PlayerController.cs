using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {
    [SerializeField] private LayerMask WhatIsGround;
    //speed stats
    public float MAXSPEED, moveSpeed, xspeed;
    public float jumpForce, secondJumpForce, jumpTime, secondJumpTime, jumpTimeCounter, secondJumpCounter;
    //this (might move back to PlayerController)
    public Player play;
    //animation(s)
    public Animator attack;
    //reference to PlayerHoldData (probably move back to PlayerController)
    public GameObject dataHolder;
    //jump checks
    public bool grounded, stoppedJumping, stoppedDoubleJumping;
    //Rigidbody2D for player
    private Rigidbody2D rigid2D;
    //Animator for player
    private Animator anim;
    //Checks for ground and ceiling
    private Transform GroundCheck, CeilingCheck;
    const float GroundedRadius = 0.2f, CeilingRadius = 0.1f;
    //facing direction
    bool facingRight = true;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        GroundCheck = transform.Find("GroundCheck");
        CeilingCheck = transform.Find("CeilingCheck");
    }

    void Start()
    {
        play = GetComponentInParent<Player>(); //grabbing player
        dataHolder = GameObject.FindGameObjectWithTag("Data"); //grabbing data
        jumpTimeCounter = jumpTime;
        secondJumpCounter = secondJumpTime;
    }

    private void FixedUpdate()
    {
        if(Input.GetAxis("Horizontal") != 0.0f)
        {
            xspeed += Input.GetAxis("Horizontal") * (moveSpeed * (1 - Time.deltaTime));
        }
        else
        {
            if ((xspeed > -0.45f && xspeed < 0.0f) || (xspeed > 0.45f && xspeed > 0.0f))
            {
                xspeed -= xspeed * 0.45f;
            }
            else
            {
                xspeed = 0;
            }
        }
        if(Mathf.Abs(xspeed) >= MAXSPEED)
        {
            xspeed = Input.GetAxis("Horizontal") * MAXSPEED;
        }
        rigid2D.velocity = new Vector2(xspeed, rigid2D.velocity.y);
        if(grounded == false && stoppedDoubleJumping == true)
        {
            rigid2D.velocity = new Vector2(rigid2D.velocity.x * 0.50f, rigid2D.velocity.y);
        }


        if (Input.GetButtonDown("Jump"))
        {
            if (grounded)
            {
                rigid2D.velocity = new Vector2(rigid2D.velocity.x, jumpForce);
                stoppedJumping = false;
                stoppedDoubleJumping = false;
            }
            else if (!grounded && stoppedJumping == true && stoppedDoubleJumping == false)
            {
                rigid2D.velocity = new Vector2(rigid2D.velocity.x, secondJumpForce);
                stoppedDoubleJumping = false;
            }
        }

        if (Input.GetButton("Jump"))
        {
            if (!stoppedJumping)
            {
                if (jumpTimeCounter > 0)
                {
                    rigid2D.velocity = new Vector2(rigid2D.velocity.x, jumpForce);
                    jumpTimeCounter -= Time.deltaTime;
                }
            }
            else if (stoppedJumping && !stoppedDoubleJumping)
            {
                if (secondJumpCounter > 0)
                {
                    rigid2D.velocity = new Vector2(rigid2D.velocity.x * 0.75f, secondJumpForce);
                    secondJumpCounter -= Time.deltaTime;
                }
            }
        }

        if(Input.GetButtonUp("Jump"))
        {
            if (!stoppedJumping)
            {
                jumpTimeCounter = 0;
                stoppedJumping = true;
            }
            else if(!stoppedDoubleJumping)
            {
                secondJumpCounter = 0;
                stoppedDoubleJumping = true;
            }
        }
    }

    public void Move(float move, bool jump)
    {

    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundedRadius, WhatIsGround);

        if(grounded)
        {
            jumpTimeCounter = jumpTime;
            secondJumpCounter = secondJumpTime;
            stoppedJumping = false;
            stoppedDoubleJumping = false;
        }
    }

    private void Flip()
    {

    }
}
