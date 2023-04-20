using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Enemigo : MonoBehaviour
{
    public GameObject Objetivo;
    public float Velocidad;
    public NavMeshAgent IA;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Find();
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.transform.position);
    }

    void Find()
    {
        Objetivo = GameObject.Find("Capsule");
    }
}
