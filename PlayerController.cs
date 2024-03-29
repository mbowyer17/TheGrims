﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]float moveSpeed;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float herz = Input.GetAxisRaw("Horizontal");
        float verz = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(herz * moveSpeed, verz * moveSpeed);

    
    }
    public float SetMovSpeed(float mspd)
    {
        moveSpeed = mspd;
        return mspd;
    }

}
