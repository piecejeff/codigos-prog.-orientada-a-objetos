﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Codigo agente
// DESARROLLADOR: Juan Pablo Tadeo Nava Marquez
//Asignatura:Programacion Orientada  objetos
//profesor josue rivadia
//este codigo es en donde se encuentran protegidos datos estos le pertenecen a los
// enemigos del videojuego la variable [SerializeField] es la que le permite proeger datos
public class Agente : MonoBehaviour
{
    [SerializeField]
    protected float velocidad;

    [SerializeField]
    protected Transform destino;

    [SerializeField]
    protected float freno;


    protected void ConfigurarDestino(Transform d)
    {
        Vector3 destinoFinal = new Vector3(d.position.x, this.transform.position.y, d.position.z);
        ConfiguracionFreno(destinoFinal, freno);

        transform.LookAt(destinoFinal);
        
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

    }

    protected bool ConfiguracionFreno(Vector3 d,float f)
    {
        float velocidadLocal = 1;
        float distancia = Vector3.Distance(transform.position, d);

        if (distancia < f)
        {
            velocidad = 0;
            return (true);
        }
        else
        {
            velocidad = velocidadLocal;
            return (false);
        }
    }
}
