using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coleccion : MonoBehaviour
{
    public int diamante = 0;

    //public AudioClip Voz1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "diamante")
        {
            Destroy(other.gameObject);

            diamante++;
            //Debug.Log("uno mas al hilo");

            if (diamante == 1)
            {
                Debug.Log("aguita de coco");
                SceneManager.LoadScene(1);
            }
        }
    }
}
