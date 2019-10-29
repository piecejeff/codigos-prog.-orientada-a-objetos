using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [Header("Aqui va tu objeto vacio model")] 
    public GameObject model;
    public string[] tipoAtaque;
    public bool MovimientoAtaque;

    public int contador;
    Animator anim;
    float velocidad = 100f; // velocidad del personaje
    float velocidadLateral = 10000f;// velocidad latera
    float rotationSpeed=2f; //rotation
    Quaternion targetModelRotation; 
    // hasta este punto se muestran las clases que se van a usar en el codigo
    // Start is called before the first frame update
    void Start()
    {
        MovimientoAtaque = false;
        contador = 0;
        anim = GetComponent<Animator>();
        velocidad = 1;
        velocidadLateral = 1000;

        targetModelRotation = Quaternion.Euler(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            contador++;
            if (contador >= 4)
            {
                contador = 0;
            } // controlador de contador
        }



        ControlGeneralMovimiento();

        //CambioAtaque();
        Ataque(contador, "contador");

    }//Fin de update






    void ControlGeneralMovimiento()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            MovimientoAtaque = true;
        }
        else
        {
            MovimientoAtaque = false;
        }



        if (MovimientoAtaque == false)
        {
            anim.SetLayerWeight(0, 1);
            anim.SetLayerWeight(1, 0);
            anim.SetLayerWeight(2, 0);
            ControlMovimiento();
        }
        else if (MovimientoAtaque == true)
        {
            anim.SetLayerWeight(0, 0);
            anim.SetLayerWeight(1, 0);
            anim.SetLayerWeight(2, 1);
            ControlMovimientoAtaque();
        }

        //lo anterior es para llevar acabo un ovimiento de ataque


    }


    void ControlMovimiento()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 direccion = new Vector3(horizontal * velocidad * Time.deltaTime, 0, vertical * Time.deltaTime);

        model.transform.rotation = Quaternion.Lerp(model.transform.rotation, targetModelRotation, Time.deltaTime * rotationSpeed);

        transform.Translate(direccion);
        anim.SetFloat("Velocidad", vertical * velocidad);
        anim.SetFloat("velocidadLateral", horizontal * velocidadLateral);
        direccion.Normalize();


        if(direccion.z > 0)
        {
            targetModelRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direccion.z < 0)
        {
            targetModelRotation = Quaternion.Euler(0, 180, 0);
        }
        if (direccion.x > 0)
        {
            targetModelRotation = Quaternion.Euler(0, 90, 0);
        }
        else if (direccion.x < 0)
        {
            targetModelRotation = Quaternion.Euler(0, 270, 0);
        }
    }//este es el contol de movimiento que se usara para el personaje


    void ControlMovimientoAtaque()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 direccion = new Vector3(horizontal * velocidad * Time.deltaTime, 0, vertical * velocidad * Time.deltaTime);



        transform.Translate(direccion);
        anim.SetFloat("velocidadAtaqueFrontal", vertical * velocidad);
        anim.SetFloat("velocidadAtaqueLateral", horizontal * velocidadLateral);
        direccion.Normalize();


    }


    void Ataque(string tipoAtaque)
    {
        if (Input.GetMouseButtonDown(0))
        {


            anim.SetBool(tipoAtaque, true);
        }
        else
        {
            anim.SetBool(tipoAtaque, false);
        }
    }

    void Ataque(int contador,string contadorText)
    {
        anim.SetInteger(contadorText, contador);



    }

    void CambioAtaque()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            contador++;
            if (contador > tipoAtaque.Length - 1)
            {
                contador = 0;
            }
        }
    }
    //este es el control de ataque y de igual manera el que marca el cambio de ataque
















}

