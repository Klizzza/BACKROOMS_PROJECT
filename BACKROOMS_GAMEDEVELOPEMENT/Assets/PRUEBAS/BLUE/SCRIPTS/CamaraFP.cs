using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFP : MonoBehaviour
{

    // Click a la pantalla de juego para que desaparezca el cursor
    // Esc para que aparezca de nuevo el cursor

    private Transform camera;
    private Transform orientacion;
    private float horizonX;
    private float vertY;
    public Vector2 sensibilidad;

    void Start()
    {
        camera = Camera.main.transform;
        // Indica que la cámara a la que nos referimos es la cámara principal de la escena
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseComp();
    }

    private void MouseComp()
    {
        horizonX = Input.GetAxis("Mouse X");
        vertY = Input.GetAxis("Mouse Y");

        if (horizonX != 0)
        {
            //transform.Rotate(Vector3.up * horiz * sensibilidad.x);
            float angulo = camera.localEulerAngles.y + horizonX * sensibilidad.x;
            camera.localEulerAngles = new Vector3(camera.localEulerAngles.x, angulo, 0);
        }

        if (vertY != 0)
        {
            float angulo = camera.localEulerAngles.x - vertY * sensibilidad.y;
            camera.localEulerAngles = new Vector3(angulo, camera.localEulerAngles.y, 0);
        }
    }

}
