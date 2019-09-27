using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Arma arma;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ApretarGatillo();
        }
    }

    void ApretarGatillo()
    {
        arma.Disparar();
    }
}
