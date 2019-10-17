using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaLanzallamas : Arma
{
    [SerializeField] GameObject prefabLlamas;
    
    public override void Disparar()
    {
        prefabLlamas.SetActive(true);
    }

    public override void SoltarGatillo()
    {
        prefabLlamas.SetActive(false);
    }
}
