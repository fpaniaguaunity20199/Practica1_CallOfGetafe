using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Arma : MonoBehaviour
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
    [Header("Variables de estado")]
    [SerializeField] bool recargando = false;
    [SerializeField] bool esperandoCadencia = false;//Esperando que pase el tiempo de cadencia
    //Munición disponible en el cargador actual
    [SerializeField] int municionCargador;

    [Header("Sonidos")]
    [SerializeField] AudioClip acShoot;
    [SerializeField] AudioClip acReload;
    [SerializeField] AudioClip acFail;
    private AudioSource audioSource;

    private void Start()
    {
        municionCargador = capacidadCargador;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(acReload);
    }

    public void IntentarDisparar()
    {
        bool puedeDisparar = municionCargador > 0 && recargando == false && esperandoCadencia == false;
        if (puedeDisparar)
        {
            Disparar();
            audioSource.PlayOneShot(acShoot);
            PostDisparar();
        } else
        {
            audioSource.PlayOneShot(acFail);
        }
    }
    public abstract void Disparar();
    public abstract void SoltarGatillo();
    public void Recargar()
    {
        if (numeroCargadores > 0 && recargando == false)
        {
            audioSource.PlayOneShot(acReload);
            recargando = true;
            Invoke("ReiniciarCargando", tiempoRecarga);
            municionCargador = capacidadCargador;
            numeroCargadores--;
        } else
        {
            audioSource.PlayOneShot(acFail);
        }
        
    }
    public void IncrementarCargador(int numeroCargadores)
    {
        this.numeroCargadores = this.numeroCargadores + numeroCargadores;
    }
    private void PostDisparar()
    {
        audioSource.PlayOneShot(acShoot);//ÑAPA
        municionCargador--;
        //TODO: Actualizar UI
        esperandoCadencia = true;
        Invoke("ReiniciarCadencia", cadencia);
    }
    private void ReiniciarCadencia()
    {
        esperandoCadencia = false;
    }
    private void ReiniciarCargando()
    {
        recargando = false;
    }
}
