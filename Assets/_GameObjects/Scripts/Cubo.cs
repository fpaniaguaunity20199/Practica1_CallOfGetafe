using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Esfera").GetComponent<Esfera>().Empujar(this.GetComponent<Rigidbody>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
