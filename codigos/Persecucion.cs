using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Codigo Persecucion
// DESARROLLADOR: Juan Pablo Tadeo Nava Marquez
//Asignatura:Programacion Orientada  objetos
//profesor josue rivadia

public class Persecucion : MonoBehaviour
{
    public Transform playerPosition;
    public float velocidadEnemigo;

    // Con playerposition delimitamos la posición del objeto con el tag player para que nuestro enemigo pueda transformar su posición hacia el player

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Perseguir(playerPosition,this.gameObject.transform);
    }

    // seleccionamos el player para que el objeto se dirija hacia el
    public void Perseguir (Transform player, Transform enemigo)
    {
        Vector3 distancia = player.position - enemigo.position;

        enemigo.LookAt(distancia);
        enemigo.Translate(distancia.normalized * velocidadEnemigo * Time.deltaTime);
    }
}
