using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFP : MonoBehaviour
{

    // Click a la pantalla de juego para que desaparezca el cursor
    // Esc para que aparezca de nuevo el cursor

    private Transform camera;
    public Vector2 sensibilidad;
    private float horiz;
    private float vert;

    void Start()
    {
        camera = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseComp();
    }

    private void MouseComp()
    {
        horiz = Input.GetAxis("Mouse X");
        vert = Input.GetAxis("Mouse Y");

        if (horiz != 0)
        {
            //transform.Rotate(Vector3.up * horiz * sensibilidad.x);
            float angulo = camera.localEulerAngles.y + horiz * sensibilidad.x;
            camera.localEulerAngles = new Vector3(camera.localEulerAngles.x, angulo, 0);
        }

        if (vert != 0)
        {
            float angulo = camera.localEulerAngles.x - vert * sensibilidad.y;
            camera.localEulerAngles = new Vector3(angulo, camera.localEulerAngles.y, 0);
        }
    }

}
