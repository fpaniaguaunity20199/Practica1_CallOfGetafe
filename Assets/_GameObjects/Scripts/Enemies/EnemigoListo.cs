using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoListo : EnemyMovil
{
    [SerializeField] int followDistance;
    [SerializeField] float distanceToPlayer;
    public void Update()
    {
        base.Update();
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer <= followDistance)
        {
            estado = ESTADO.Siguiendo;
            Vector3 target = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
            transform.LookAt(target);
        } else
        {
            estado = ESTADO.Normal;
        }
    }
}
