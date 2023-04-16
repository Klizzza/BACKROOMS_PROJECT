using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IA_Dos : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;

    public GameObject Capsule;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.destination = Capsule.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
