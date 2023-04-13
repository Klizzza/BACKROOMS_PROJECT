using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Behaviour : MonoBehaviour
{
    [SerializeField] Light flashlight;
    [SerializeField] TMP_Text no_bateria_txt;
    [SerializeField] TMP_Text bateria_restante_txt;
    private bool encendido;
    private float bateria_restante = 20;
    public float no_baterias = 1;

    // Start is called before the first frame update
    void Start()
    {
        flashlight.intensity = 0;
        encendido = false;
    }

    // Update is called once per frame
    void Update()
    {
        Textos();
        Onoff();
        Bateria_Restante();
        Baterias();
    }
    void Onoff()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (encendido == false)
            {
                flashlight.intensity = 400000;
                encendido = true;
                return;
            }

            else if (encendido == true)
            {

                flashlight.intensity = 0;
                encendido = false;
                return;
            }
        }
    }

    void Textos()
    {
        no_bateria_txt.text = "Baterias: " + no_baterias.ToString();
        bateria_restante_txt.text = "Bateria restante: " + bateria_restante.ToString() + "%";
    }

    void Bateria_Restante()
    {
        if (encendido == true)
        {
            bateria_restante -= 1 * Time.deltaTime;
        }
        if (bateria_restante <= 0)
        {
            flashlight.intensity = 0;
            encendido = false;
            bateria_restante = 0;
        }
        if (bateria_restante >= 100)
        {
            bateria_restante = 100;
        }
    }

    void Baterias()
    {
        if(Input.GetKeyDown(KeyCode.R) && no_baterias >= 1)
        {
            no_baterias -= 1;
            bateria_restante += 20;
        }

        if (Input.GetKeyDown(KeyCode.R) && no_baterias == 0)
        {
            return;
        }

        if (no_baterias <= 0)
        {
            no_baterias = 0;
        }
    }
}
