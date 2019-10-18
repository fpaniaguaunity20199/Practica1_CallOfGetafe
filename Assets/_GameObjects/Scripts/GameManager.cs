using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    public int numeroEnemigos;
    public GameObject canvasReload;

    private void Start()
    {
        Time.timeScale = 1;
        numeroEnemigos = GameObject.FindObjectsOfType<Enemy>().Length;
        StartCoroutine("ComprobarFinJuego");
    }

    IEnumerator ComprobarFinJuego()
    {
        while (numeroEnemigos>0)
        {
            //El juego está activo
            yield return new WaitForSeconds(3f);//CEDE EL CONTROL
            numeroEnemigos = GameObject.FindObjectsOfType<Enemy>().Length;
        }
        //Instanciar el BOSS
        print("FIN DE JUEGO");
        GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
        canvasReload.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
    }
}