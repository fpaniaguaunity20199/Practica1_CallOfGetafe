using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLerp : MonoBehaviour
{
    private Light puntoDeLuz;
    private float t;

    private void Start()
    {
        puntoDeLuz = GetComponent<Light>();
    }

    void Update()
    {
        t = t + Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.L))
        {
            puntoDeLuz.enabled = !puntoDeLuz.enabled;
        }
        puntoDeLuz.color = new Color(Mathf.Lerp(0, 1, t * 0.1f), Mathf.Lerp(0, 1, t * 0.25f), 0);
    }
}
