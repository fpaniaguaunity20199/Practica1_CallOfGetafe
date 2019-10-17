using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaProyectil : Arma
{
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] Transform puntoDisparo;
    [SerializeField] float fuerza;
    public override void Disparar()
    {
        GameObject proyectil = Instantiate(prefabProyectil, puntoDisparo.position, puntoDisparo.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(puntoDisparo.forward * fuerza);
    }

    public override void SoltarGatillo()
    {
        //NO HAGO NADA
    }
}
