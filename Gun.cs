﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public Rigidbody BULLET;
	public Transform FIRESPOT;
	public float power;

	private Rigidbody projectile;
	private bool fire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetButtonDown("Fire1"))
        {
        	projectile = Instantiate(BULLET, FIRESPOT.position, transform.rotation);
        	fire = true;
        }
        
    }

    private void FixedUpdate()
    {
    	if(fire)
   		{
   			projectile.velocity = transform.TransformDirection(Vector3.left * power);
   			fire = false;
   			Destroy(projectile.gameObject, 3);
    	}
     }


}