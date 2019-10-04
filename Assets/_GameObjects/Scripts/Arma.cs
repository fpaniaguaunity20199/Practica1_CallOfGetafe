using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//////////// UI

public class Arma : MonoBehaviour
{
    [SerializeField] Text txtPuntuacion;//////////// UI
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] Transform puntoInicioProyectil;
    [SerializeField] float fuerza;
    [SerializeField] int capacidadCargador;
    [SerializeField] int numeroBalas;

    private void Awake()
    {
        numeroBalas = capacidadCargador;
        txtPuntuacion.text = numeroBalas.ToString();//////////// UI
    }

    private void Start()
    {

    }




    public void Recargar(int numeroBalasExtra)
    {
        numeroBalas = Mathf.Min(numeroBalas + numeroBalasExtra,capacidadCargador);
        txtPuntuacion.text = numeroBalas.ToString();//////////// UI
    }

    public void Disparar()
    {
        if (numeroBalas > 0)
        {
            numeroBalas--;
            txtPuntuacion.text = numeroBalas.ToString();//////////// UI
            //Generamos el proyectil
            GameObject proyectil = Instantiate(prefabProyectil);
            //Asignamos al proyectil la posición y rotación del punto de spawn
            proyectil.transform.position = puntoInicioProyectil.position;
            proyectil.transform.rotation = puntoInicioProyectil.rotation;
            //Impulsamos el proyectil
            proyectil.GetComponent<Rigidbody>().AddForce(proyectil.transform.forward * fuerza);
        }
        else
        {
            print("Cargador vacio");
        }
    }
}
