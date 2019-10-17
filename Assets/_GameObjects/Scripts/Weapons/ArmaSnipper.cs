using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSnipper : Arma
{
    [Header("Zoom")]
    [SerializeField] Camera camara;
    [SerializeField] Canvas canvas;
    [Header("Weapon config.")]
    [SerializeField] int danyo;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            camara.fieldOfView = 20;
            canvas.gameObject.SetActive(true);
        } else if (Input.GetMouseButtonUp(1))
        {
            camara.fieldOfView = 60;
            canvas.gameObject.SetActive(false);
        }
    }

    public override void Disparar()
    {
        Ray rayo = new Ray(camara.transform.position, camara.transform.forward);
        RaycastHit hitInfo;
        bool hayImpacto = Physics.Raycast(rayo, out hitInfo);
        if (hayImpacto)
        {
            if (hitInfo.transform.CompareTag("Enemy"))
            {
                hitInfo.transform.gameObject.GetComponent<Enemy>().RecibirDanyo(danyo);
            }
        }
    }

    public override void SoltarGatillo()
    {
        //NO HAGO NADA
    }
}
