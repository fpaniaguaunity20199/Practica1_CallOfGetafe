using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTorre : Enemy
{
    [SerializeField] float attackDistance;
    [SerializeField] float speed;
    private float distanceToPlayer;


    private void Update()
    {
        base.Update();
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer < attackDistance)
        {
            Quaternion q = Quaternion.LookRotation(
                player.transform.position - 
                transform.position);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, 
                q, 
                Time.deltaTime * speed);
        }
    }

}
