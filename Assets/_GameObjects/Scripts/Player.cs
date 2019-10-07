using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Arma[] armas;
    [SerializeField] int armaActiva = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ApretarGatillo();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivarArma(0);
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivarArma(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivarArma(2);
        } else if (Input.GetKeyDown("4"))
        {
            ActivarArma(3);
        }
    }

    void ActivarArma(int numeroArma)
    {
        if (numeroArma != armaActiva)
        {
            //OPCION 1

            armas[armaActiva].gameObject.SetActive(false);
            armaActiva = numeroArma;
            armas[armaActiva].gameObject.SetActive(true);

            //OPCION 2

            /*
            armaActiva = numeroArma;
            for(int i = 0; i < armas.Length; i++)
            {
                armas[i].gameObject.SetActive(false);
            }
            armas[armaActiva].gameObject.SetActive(true);
            */
        }
    }

    public void Recargar(int numeroBalas)
    {
        //arma.Recargar(numeroBalas);
    }


    void ApretarGatillo()
    {
        //armas[armaActiva].Disparar();
    }
}
