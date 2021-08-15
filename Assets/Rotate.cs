using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vec = new Vector3(1, 1, 0);
    public int speed = 3;

    private Transform _transform; 
        
    private void Start()
    {
        _transform = this.transform;
    }

    private void FixedUpdate()
    {
        transform.Rotate(vec * speed);
    }
}
