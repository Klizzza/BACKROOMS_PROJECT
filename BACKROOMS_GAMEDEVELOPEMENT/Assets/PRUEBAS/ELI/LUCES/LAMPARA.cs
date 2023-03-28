using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAMPARA : MonoBehaviour
{
    // Variables de campo
    [SerializeField] Transform punto_Luz;

    // Variables
    private bool encendido;
    Transform luzTransform;
    Light lampara_Code;

    // Start is called before the first frame update
    void Start()
    {
        encendido = true;
        Luz();
    }

    // Update is called once per frame
    void Update()
    {
        luzTransform.LookAt(punto_Luz);
        Encendido_Apagado();
    }

    public void Luz()
    {
        GameObject luz_Lampara = new GameObject("luz_Lampara");
        luzTransform = luz_Lampara.transform;
        Light comp_Luz_Lampara = luz_Lampara.AddComponent<Light>();
        comp_Luz_Lampara.type = LightType.Spot;
        Vector3 posicionLuz = new Vector3(0, 4, 0);
        comp_Luz_Lampara.transform.position = posicionLuz;
        lampara_Code = comp_Luz_Lampara;
    }
    void Encendido_Apagado()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (encendido == false)
            {
                lampara_Code.intensity = 1;
                encendido = true;
                return;
            }

            else if (encendido == true)
            {

                lampara_Code.intensity = 0;
                encendido = false;
                return;
            }
        }
    }
}
