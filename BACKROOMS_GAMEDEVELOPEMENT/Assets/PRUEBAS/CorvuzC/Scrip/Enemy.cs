using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator ani;
    public Quaternion angulo;
    public float grado;
    public bool atacando;
    public NavMeshAgent agente;
    public float speed;
    public float distancia_ataque;
    public float radio_vision;
    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.Find("Capsule");
    }

    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > radio_vision)
        {
            agente.enabled = false;
            ani.SetBool("Run", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    ani.SetBool("Walk", false);
                    break;

                case 1:
                    grado = Random.Range(0, 0);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    ani.SetBool("Walk", true);
                    break;
            }
        }
        else
        {
            var lookPos = target.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);

            agente.enabled = true;
            agente.SetDestination(target.transform.position);
            if(Vector3.Distance(transform.position,target.transform.position)>distancia_ataque && !atacando)
            {
                ani.SetBool("Walk", false);
                ani.SetBool("Run", true);
            }
            else
            {
                if (!atacando)
                {
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 1);
                    ani.SetBool("Walk", false);
                    ani.SetBool("Run", false);
                }
            }
        }
        if (atacando)
        {
            agente.enabled = false;
        }
    }

    public void Final_ani()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > distancia_ataque + 0.2f)
        {
            ani.SetBool("Attack", false);
        }
        atacando = false;
      
    }
    // Update is called once per frame
    void Update()
    {
        Comportamiento_Enemigo();
    }

   
}
