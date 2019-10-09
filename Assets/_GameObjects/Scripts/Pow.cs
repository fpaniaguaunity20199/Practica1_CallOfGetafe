using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pow : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //OPCION 1
            //GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemy");
            //for(int i = 0; i < enemigos.Length; i++)
            //{
            //    enemigos[i].GetComponent<Enemy>().RecibirDanyo(50);
            //}
            //OPCION 2
            //Enemy[] enemigos = GameObject.FindObjectsOfType<Enemy>();
            //for (int i = 0; i < enemigos.Length; i++)
            //{
            //    enemigos[i].RecibirDanyo(50);
            //}
            //OPCION 3
            Enemy.efectoMagia = true;

            Destroy(gameObject);
        }

    }


}
