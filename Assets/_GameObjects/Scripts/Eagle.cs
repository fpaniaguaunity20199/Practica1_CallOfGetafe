﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 3);
    }
}
