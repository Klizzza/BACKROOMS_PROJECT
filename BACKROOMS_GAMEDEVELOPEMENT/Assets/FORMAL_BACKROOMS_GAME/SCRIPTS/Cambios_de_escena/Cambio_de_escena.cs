using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_de_escena : MonoBehaviour
{
    public void Boton_a_menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Boton_a_controles()
    {
        SceneManager.LoadScene(2);
    }
    public void Boton_a_LVL1()
    {
        SceneManager.LoadScene(6);
    }
    public void Boton_a_LVL2()
    {
        SceneManager.LoadScene(5);
    }

    public void Boton_Salir()
    {
        Application.Quit();
    }
}
