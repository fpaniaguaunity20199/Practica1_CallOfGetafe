using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboLerp : MonoBehaviour
{
    public Transform p1, p2;
    public float speed;
    float t = 0f;
    int factor = 1;

    void Update()
    {
        t = t + Time.deltaTime * factor;
        transform.position = Vector3.Lerp(p1.position, p2.position, t * speed);
        if (t >= (1 / speed))
        {
            factor = -1;
        } else if (t<=0)
        {
            factor = 1;
        }
    }
}
