using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    float rot;
    // Update is called once per frame
    void Update()
    {
         rot += Input.GetAxis("Horizontal2")*2;
        rot = Mathf.Clamp(rot, -60,60);
       

        transform.rotation = Quaternion.Euler(0, rot, 0); //esta es para transformar su rotation

        if (rot <= -60||rot >= 60 )
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward.normalized*Time.deltaTime);
            
        }
        transform.Rotate (0, rot * 1f, 0);

        // este codigo es para que el personaje rote sin problema
    }
}
