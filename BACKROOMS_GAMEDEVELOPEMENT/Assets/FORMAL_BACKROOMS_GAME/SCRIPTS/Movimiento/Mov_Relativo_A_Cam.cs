using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Relativo_A_Cam : MonoBehaviour
{
    // Variables
    private Rigidbody rigid_Bod;
    private float inputX;
    private float inputY;
    [SerializeField] float walking_speed = 5.5f;
    [SerializeField] Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        rigid_Bod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        Vector3 cam_Adelante = cam.forward;
        Vector3 cam_Der = cam.right;
        cam_Adelante.y = 0;
        cam_Der.y = 0;

        Vector3 guia_Delante = inputY * cam_Adelante;
        Vector3 guia_Der = inputX * cam_Der;

        Vector3 dir_Movement = guia_Delante + guia_Der;

        inputX = Input.GetAxisRaw("Horizontal") * walking_speed;
        inputY = Input.GetAxisRaw("Vertical") * walking_speed;

        rigid_Bod.velocity = new Vector3(dir_Movement.x, 0, dir_Movement.z);
    }
}
