using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salud_Prota : MonoBehaviour
{
    public float Salud = 100;
    public float SaludMax = 100;

    void Update ()
    {

    }

    public void RecibirDa�o (float da�o)
    {
        Salud -= da�o;

        if (Salud <= 0)
        {
            SceneManager.LoadScene(2);
            Destroy(gameObject);
        }

    }

    
}
