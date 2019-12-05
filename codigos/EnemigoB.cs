using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Codigo EnemigoB
// DESARROLLADOR: Juan Pablo Tadeo Nava Marquez
//Asignatura:Programacion Orientada  objetos
//profesor josue rivadia

public class EnemigoB : MonoBehaviour
{
    public List<Enemigo> enemigo;



    // Start is called before the first frame update
    void Awake() // entra antes de entrar al software
                //  divide fases de ejecuion
    {
        enemigo.Add(new Enemigo(100, 50, "Hongito"));
        enemigo.Add(new Enemigo(200, 500, "Momia"));
        enemigo.Add(new Enemigo(50, 50, "Conejito"));
        enemigo.Add(new Enemigo(100, 1000, "Cubo"));
        enemigo.Add(new Enemigo(100, 1000, "Huesitos"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
