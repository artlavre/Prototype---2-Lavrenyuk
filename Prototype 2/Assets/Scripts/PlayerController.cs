﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10f;
    [SerializeField]
    private float xRange = 10;

    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //Movement
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y , transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y , transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
