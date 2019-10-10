using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //ESTADO DEL ENEMIGO
    protected enum ESTADO { Normal, Siguiendo};
    protected ESTADO estado = ESTADO.Normal;
    //REFERENCIAL PLAYER
    protected GameObject player;

    //CONFIGURACIÓN
    [SerializeField] TextMesh textoVida;
    public int vida;
    public int danyo;//Daño que infringe al player
    public GameObject prefabExplosion;
    public static bool efectoMagia = false;

    public void Start()
    {
        player = GameObject.Find("Player");
        textoVida.text = vida.ToString();
    }
    public void Update()
    {
        if (efectoMagia)
        {
            RecibirDanyo(50);
            var renderer = GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.red);
        }
    }

    private void LateUpdate()
    {
        efectoMagia = false;
    }

    public void RecibirDanyo(int danyoRecibido)
    {
        vida = vida - danyoRecibido;
        textoVida.text = vida.ToString();
        if (vida <= 0)
        {
            Morir();
        }
    }

    public void Atacar()
    {

    }

    public void Morir()
    {
        Instantiate(prefabExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
 }
