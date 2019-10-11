using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSnipper : Arma
{
    [Header("Zoom")]
    [SerializeField] Camera camara;
    [SerializeField] Canvas canvas;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            camara.fieldOfView = 20;
            canvas.gameObject.SetActive(true);
        } else if (Input.GetMouseButtonUp(1))
        {
            camara.fieldOfView = 60;
            canvas.gameObject.SetActive(false);
        }
    }

    public override void Disparar()
    {
        print("DISPARANDO");
    }
}
