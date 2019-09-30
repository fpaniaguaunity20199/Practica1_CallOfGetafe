﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField] float speed;
    
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
