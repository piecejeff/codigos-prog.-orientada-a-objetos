﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    crear_enem dañoEnemigo;


    public string etiqueta;
    // Start is called before the first frame update
    void Start()
    {
        //dañoEnemigo = GetComponentInParent<crear_enem>();
        Debug.Log(dañoEnemigo.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dañoEnemigo.vida-=10;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == etiqueta)
        {
            dañoEnemigo.vida -= 10;

        }
    }
}