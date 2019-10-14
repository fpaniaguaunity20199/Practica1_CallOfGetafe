using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPesado : MonoBehaviour
{
    private Transform player;
    public float speed;
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed);
    }
}
