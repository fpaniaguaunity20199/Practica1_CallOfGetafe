using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//AGREGAR EL PAQUETE DE GESTION DE ESCENAS

public class Teleporter : MonoBehaviour
{
    [SerializeField] string nombreEscena;
    [SerializeField] float delay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Invoke("CambiarEscena", delay);
        }
    }
    private void CambiarEscena()
    {
        SceneManager.LoadScene(nombreEscena);
    }
}