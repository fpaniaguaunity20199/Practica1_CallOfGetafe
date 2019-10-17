using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTorre : Enemy
{
    [SerializeField] float attackDistance;
    [SerializeField] float speed;
    [SerializeField] float cadenciaAtaque;
    [SerializeField] Transform puntoDisparo;
    [SerializeField] float fuerzaDisparo;
    [SerializeField] GameObject prefabProyectil;
    private float distanceToPlayer;
    private bool atacando = false;

    private void Start()
    {
        base.Start();
        InvokeRepeating("Atacar", cadenciaAtaque, cadenciaAtaque);
    }

    private void Update()
    {
        base.Update();
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer < attackDistance)
        {
            atacando = true;
            Quaternion q = Quaternion.LookRotation(
                player.transform.position - 
                transform.position);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, 
                q, 
                Time.deltaTime * speed);
        } else
        {
            atacando = false;
        }
    }
    private void Atacar()
    {
        if (atacando)
        {
            GameObject proyectil = Instantiate(prefabProyectil, puntoDisparo.transform.position, puntoDisparo.transform.rotation);
            proyectil.GetComponent<Rigidbody>().AddForce(puntoDisparo.forward * fuerzaDisparo);
        }
    }
}
