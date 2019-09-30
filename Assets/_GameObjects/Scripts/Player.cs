using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Arma arma;
    private Arma otra;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ApretarGatillo();
        }
    }

    public void Recargar(int numeroBalas)
    {
        arma.Recargar(numeroBalas);
    }


    void ApretarGatillo()
    {
        arma.Disparar();
    }
}
