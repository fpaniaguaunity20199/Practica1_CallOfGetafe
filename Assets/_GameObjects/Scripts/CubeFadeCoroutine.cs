using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFadeCoroutine : MonoBehaviour
{
    Renderer miRenderer;
    void Start()
    {
        miRenderer = GetComponent<Renderer>();
        StartCoroutine("Fade");
    }

    IEnumerator Fade()
    {
        for (float ft = 1f; ft >= 0; ft -= 0.05f)
        {
            Color c = miRenderer.material.color;
            c.a = ft;
            miRenderer.material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
