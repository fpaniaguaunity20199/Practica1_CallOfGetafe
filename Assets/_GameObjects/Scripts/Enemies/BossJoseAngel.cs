using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossJoseAngel : MonoBehaviour
{
    public Transform transformPlayer;
    public Vector3 posicionPlayer;
    public Vector3 posicionJoseAngel;
    public int tiempoEntreAtaques;
    public bool atacando = false;
    public float speed;

    void Start()
    {
        transformPlayer = GameObject.Find("Player").transform;
        InvokeRepeating("ComenzarAtaque", tiempoEntreAtaques, tiempoEntreAtaques);
    }

    void ComenzarAtaque()
    {
        if (!atacando)
        {
            atacando = true;
            posicionPlayer = new Vector3(transformPlayer.position.x, transform.position.y, transformPlayer.position.z);
            posicionJoseAngel = transform.position;
            StartCoroutine("Atacar");
        }
    }
    IEnumerator Atacar()
    {
        for (float t = 0; t <= 1; t = t + speed)
        {
            transform.position = Vector3.Lerp(posicionJoseAngel, posicionPlayer, t);
            yield return new WaitForSeconds(speed);
        }
        for (float t = 0; t <= 1; t = t + speed)
        {
            transform.position = Vector3.Lerp(posicionPlayer, posicionJoseAngel, t);
            yield return new WaitForSeconds(speed);
        }
        atacando = false;
    }
}
