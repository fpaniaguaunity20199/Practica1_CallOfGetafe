using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMunicion : MonoBehaviour
{
    [SerializeField] int numeroBalas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //Recargar el arma
            //other.gameObject.GetComponent<Player>().Recargar(numeroBalas);
            //Hacemos que desaparezca el cubo
            Destroy(gameObject);
        }
    }
}
