using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_nivel : MonoBehaviour
{
    private bool rango;

    // Start is called before the first frame update
    void Start()
    {
        rango = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            rango = true;
            SceneManager.LoadScene(1);
        }
    }

}
