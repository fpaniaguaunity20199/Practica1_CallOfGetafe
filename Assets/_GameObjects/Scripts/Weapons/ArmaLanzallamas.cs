using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaLanzallamas : Arma
{
    [SerializeField] GameObject prefabLlamas;
    [SerializeField] Transform origenDolor;
    [SerializeField] float radioDolor;
    [SerializeField] bool disparando;
    [SerializeField] int danyo;
    [SerializeField] float tiempoEntreDanyo;
    public override void Disparar()
    {
        prefabLlamas.SetActive(true);
        disparando = true;
        StartCoroutine("Achicharrar");
    }

    public override void SoltarGatillo()
    {
        prefabLlamas.SetActive(false);
        disparando = false;
    }
    IEnumerator Achicharrar()
    {
        while (disparando)
        {
            Collider[] malos = Physics.OverlapSphere(origenDolor.position, radioDolor);
            foreach(Collider col in malos)
            {
                if (col.gameObject.CompareTag("Enemy"))
                {
                    col.gameObject.GetComponent<Enemy>().RecibirDanyo(danyo);
                }
            }
            yield return new WaitForSeconds(tiempoEntreDanyo);
        }
    }
}
