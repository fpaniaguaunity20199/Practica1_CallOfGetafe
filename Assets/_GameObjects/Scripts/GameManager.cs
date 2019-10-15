using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int numeroEnemigos;

    private void Start()
    {
        numeroEnemigos = GameObject.FindObjectsOfType<Enemy>().Length;
        StartCoroutine("ComprobarFinJuego");
    }

    IEnumerator ComprobarFinJuego()
    {
        while (numeroEnemigos>0)
        {
            //El juego está activo
            yield return new WaitForSeconds(0.1f);//CEDE EL CONTROL
            numeroEnemigos = GameObject.FindObjectsOfType<Enemy>().Length;
        }
        print("FIN DE JUEGO");
    }
}