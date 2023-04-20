using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir_Enemigo : MonoBehaviour
{
    GameObject respawn;
    private bool en_Rango;
    private float destruction_tempo = 3;
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
        Find();
        Timing();
        Debug.Log(destruction_tempo);
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
        if (en_Rango == true && on == true && destruction_tempo <= 0)
        {
            Destroy(gameObject);
            respawn.GetComponent<Respawn>().vivo = false;
        }
    }

    void Timing()
    {
        if (en_Rango == true && on == true)
        {
            destruction_tempo -= 1 * Time.deltaTime;
        }
    }

    void Find()
    {
        respawn = GameObject.Find("Respawn");
    }
}
