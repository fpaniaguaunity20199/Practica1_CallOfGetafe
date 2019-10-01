using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTonto : EnemyMovil
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Proyectil"))
        {
            Instantiate(prefabExplosion, transform.position, transform.rotation);
        }
    }
}
