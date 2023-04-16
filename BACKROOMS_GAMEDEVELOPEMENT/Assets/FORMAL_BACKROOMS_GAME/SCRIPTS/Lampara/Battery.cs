using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField] GameObject recoger_txt;
    [SerializeField] GameObject flashlight;
    private bool en_Rango;
    

    // Start is called before the first frame update
    void Start()
    {
        recoger_txt.SetActive(false);
        en_Rango = false;
    }

    // Update is called once per frame
    void Update()
    {
        Activador();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            en_Rango = true;
            recoger_txt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            en_Rango = false;
            recoger_txt.SetActive(false);
        }
    }

    void Activador()
    {
        if(Input.GetKeyDown(KeyCode.F) && en_Rango)
        {
            flashlight.GetComponent<Behaviour>().no_baterias += 1;
            en_Rango = false;
            recoger_txt.SetActive(false);
            Destroy(gameObject);
        }
    }
}
