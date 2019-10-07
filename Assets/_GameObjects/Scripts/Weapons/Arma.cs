using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [Space(30)]
    [Header("Tiempo entre disparos(segundos)")]
    [Range(0,10)]
    [SerializeField] float cadencia;//Tiempo entre disparos (segundos)
    [Header("Capacidad de proyectiles en un cargador")]
    [SerializeField] int capacidadCargador;
    [Header("Tiempo de recarga (segundos)")]
    [Range(0, 4)]
    [SerializeField] float tiempoRecarga;
    [Header("Número de cargadores en la mochila")]
    [SerializeField] int numeroCargadores;
    //Munición disponible en el cargador actual
    private int municionCargador;

    public void IntentarDisparar()
    {

    }

    private void Disparar()
    {

    }
    public void Recargar()
    {
    }
    public void IncrementarCargador(int numeroCargadores)
    {
        this.numeroCargadores = this.numeroCargadores + numeroCargadores;
    }
}
