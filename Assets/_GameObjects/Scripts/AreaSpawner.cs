using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float delay;
    [SerializeField] int limit;
    [SerializeField] Transform limiteSuperior;
    [SerializeField] Transform limiteInferior;
    private int numeroInstancias;

    void Start()
    {
        InvokeRepeating("Spawnear", 0, delay);
    }

    void Spawnear()
    {
        float x = Random.Range(limiteInferior.position.x, limiteSuperior.position.x);
        float y = transform.position.y;
        float z = Random.Range(limiteInferior.position.z, limiteSuperior.position.z);
        Instantiate(prefab, new Vector3(x, y, z), transform.rotation);
        numeroInstancias++;//Es lo mismo que numeroInstancias=numeroInstancias+1;
        if (numeroInstancias == limit)
        {
            CancelInvoke();
        }
    }
}
