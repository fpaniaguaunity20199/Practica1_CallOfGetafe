using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] GameObject prefabBala;
    [SerializeField] Transform transformPuntoDeDisparo;
    [SerializeField] float fuerzaDisparo;

    public void Disparar()
    {
        //1. Instanciar la bala (necesito el prefab de la bala)
        GameObject bala = Instantiate(prefabBala);
        //1.5. Posicionar la bala (necesito el punto de spawn)
        bala.transform.position = transformPuntoDeDisparo.transform.position;
        bala.transform.rotation = transformPuntoDeDisparo.transform.rotation;
        //2.Impulsar la bala (necesito el rigidbody de la bala)
        bala.GetComponent<Rigidbody>().AddForce(0, 0, fuerzaDisparo);
    }
}
