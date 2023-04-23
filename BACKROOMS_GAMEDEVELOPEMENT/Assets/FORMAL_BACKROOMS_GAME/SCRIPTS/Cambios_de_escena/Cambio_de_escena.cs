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
        SceneManager.LoadScene(1);
    }
    public void Boton_a_LVL1()
    {
        SceneManager.LoadScene(3);
    }
    public void Boton_Salir()
    {
        Application.Quit();
    }
}
