using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Arma arma;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        print("DISPARAR");
        arma.Disparar();
    }


}
