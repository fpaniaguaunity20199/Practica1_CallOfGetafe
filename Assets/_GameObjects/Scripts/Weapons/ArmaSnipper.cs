using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSnipper : Arma
{
    [Header("Zoom")]
    [SerializeField] Camera camara;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            camara.fieldOfView = 20;
        } else if (Input.GetMouseButtonUp(1))
        {
            camara.fieldOfView = 60;
        }
    }

    public override void Disparar()
    {
        print("DISPARANDO");
    }
}
