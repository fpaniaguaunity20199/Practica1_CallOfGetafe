using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 400);
    }

    private void Update()
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, Time.deltaTime * 10);
    }

    private void OnMouseDown()
    {
        Empujar(GetComponent<Rigidbody>());
    }

    public void Empujar(Rigidbody rigidbody)
    {
        rigidbody.AddForce(rigidbody.gameObject.transform.forward * 300);

        Debug.Log("xxx");
        Debug.LogWarning("PLAYER:warning");
        Debug.LogError("PLAYER:HAY UN ERROR");
        Debug.LogError("TELETRANSPORTE:HAY UN ERROR");

    }

    private void OnTriggerEnter(Collider other)
    {
        print("TRIGGER:" + transform.gameObject.name + ":" + other.gameObject.name);
    }

}
