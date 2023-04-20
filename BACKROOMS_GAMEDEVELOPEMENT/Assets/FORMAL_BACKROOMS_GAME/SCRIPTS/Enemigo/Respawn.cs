using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Transform respawn;
    public bool vivo;

    // Start is called before the first frame update
    void Start()
    {
        vivo = true;
    }

    // Update is called once per frame
    void Update()
    {
        Reespawn();
        Debug.Log(vivo);
    }

    void Reespawn()
    {
        if (vivo == false)
        {
            Instantiate(enemy, respawn.position, respawn.rotation);
            vivo = true;
        }
    }
}
