using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public void Empujar(Rigidbody rigidbody)
    {
        rigidbody.AddForce(rigidbody.gameObject.transform.forward * 300);
    }

}
