﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward: MonoBehaviour
{
    public float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(transform.position.z > 30)
        {
            Destroy(gameObject);
        }else if(transform.position.z < -10)
        {
            Debug.Log("lose");
            Destroy(gameObject);
        }
        
    }
}
