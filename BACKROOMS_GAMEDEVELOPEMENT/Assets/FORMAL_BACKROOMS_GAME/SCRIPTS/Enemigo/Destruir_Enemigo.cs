using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir_Enemigo : MonoBehaviour
{
    private bool en_Rango;
    public bool on;

    // Start is called before the first frame update
    void Start()
    {
        en_Rango = false;
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        Activador();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            en_Rango = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            en_Rango = false;
        }
    }

    void Activador()
    {
        if (en_Rango == true && on == true)
        {
            Destroy(gameObject);
        }
    }
}
