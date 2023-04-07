using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off : MonoBehaviour
{
    [SerializeField] Light flashlight;
    private bool encendido;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.intensity = 0;
        encendido = false;
    }

    // Update is called once per frame
    void Update()
    {
        Onoff();
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
}
