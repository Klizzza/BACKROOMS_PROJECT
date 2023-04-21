using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    public float NumDaño;
    
    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag ("Reach") && other.GetComponent<Salud_Prota>())
        {
            other.GetComponent<Salud_Prota>().RecibirDaño(NumDaño);

        }
    }

}
