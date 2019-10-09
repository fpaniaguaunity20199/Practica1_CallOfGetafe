using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovil : Enemy
{
    public float speed;
    public float tiempoEntreRotacion;
    public void Start()
    {
        base.Start();
        InvokeRepeating("Rotar", tiempoEntreRotacion, tiempoEntreRotacion);
    }
    private void Update()
    {
        base.Update();
        Mover();
    }
    public void Mover()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public void Rotar()
    {
        transform.Rotate(0, Random.Range(-180, 180), 0);
    }
}
