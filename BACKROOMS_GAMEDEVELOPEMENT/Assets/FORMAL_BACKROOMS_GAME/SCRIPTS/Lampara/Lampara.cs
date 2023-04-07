using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampara : MonoBehaviour
{
    [SerializeField] private Transform light_following;
    [SerializeField] private Light luz_lampara;
    [SerializeField] Transform luz_Transform;

    // Start is called before the first frame update
    void Start()
    {
        //luz_lampara.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        luz_Transform.transform.LookAt(light_following);
    }
}
