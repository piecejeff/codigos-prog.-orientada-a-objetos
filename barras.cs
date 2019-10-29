using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barras : MonoBehaviour
{
    public Slider[] Barras;
    public int vida;
    crear_enem vidaEnemigo;
    
    // Start is called before the first frame update
    void Start()
    {
        vidaEnemigo = GetComponentInParent<crear_enem>();


        StartCoroutine("asignarBarra");



    }

    // Update is called once per frame
    void Update()
    {
        Barras[0].value = vidaEnemigo.vida;
        if (vidaEnemigo.vida == 0)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }
    IEnumerator asignarvida()
    {
        yield return new WaitForSeconds(1);
            if (vidaEnemigo != null)
        {
            vida = vidaEnemigo.vida;
            Barras[0].maxValue = vida;
            Barras[0].value = Barras[0].maxValue;
        }
    }
    IEnumerator asignarBarra()
    {
        yield return new WaitForSeconds(1);
        Barras = new Slider[2];
        Barras = GetComponentsInChildren<Slider>();
        vida = vidaEnemigo.vida;
        for (int i = 0; i < Barras.Length; i++)
        {
            Barras[i].maxValue = vida;
            Barras[i].value = Barras[i].maxValue;
        }
    }


}
// EN ESTE CODIGO SE USARA EN UN CANVAS EL CUAL NOS SERVIRA PARA PONBER BARRAS DE VIDA A LOS PERSONAJES Y LE AYUDARA AL
// USUARIO VER EL ESTADO DE ENEMIGOS Y SU ENEMIGO