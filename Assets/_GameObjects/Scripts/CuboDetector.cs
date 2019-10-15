using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("TRIGGER CUBO:" + transform.gameObject.name + ":" + other.gameObject.name);
    }
}
