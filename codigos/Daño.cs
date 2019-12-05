using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Codigo Daño
// DESARROLLADOR: Juan Pablo Tadeo Nava Marquez
//Asignatura:Programacion Orientada  objetos
//profesor josue rivadia
.
public class Daño : MonoBehaviour
{
    Crearenemigo dañoEnemigo;
    public string etiqueta;    // volver reciclable



    // Start is called before the first frame update
    void Start()
    {
        dañoEnemigo = GetComponentInParent<Crearenemigo>();
        Debug.Log(dañoEnemigo.name);
    }

    // Update is called once per frame
    void Update()
    {
       //if (Input.GetKeyDown(KeyCode.Space))
       //{
       //    dañoEnemigo.vida -= 10;

       //}
      
    }
    private void OnCollisionEnter(Collision collision) // aqui se muestra colision que tendra objeto
    {
        if (collision.gameObject.tag==etiqueta)
        {
            dañoEnemigo.vida -= 10; // daño que hace enemigo
        }
    }
}
