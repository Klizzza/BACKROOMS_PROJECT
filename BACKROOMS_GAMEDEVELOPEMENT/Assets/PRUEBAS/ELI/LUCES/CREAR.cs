using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREAR : MonoBehaviour
{
    // VARIABLES
    [SerializeField] private Transform punto_De_Luz;
    /* Creamos esta variable para que en la interfaz de Unity se nos muestre un
     * campo donde colocaremos un objeto (puede ser lo que sea porque no especificamos
     * qu� tipo de variable es) el objeto debe estar en la posici�n a d�nde queremos
     * que apunte la luz que vamos a crear
    */
    Transform luz_Con_Transform;
    /* Esta variable es necesaria porque al ser creada fuera de cualquier funci�n,
     * es una variable global dentro de este script, lo que permitir� a otras funciones
     * interactuar con ella, a diferencia de las variables que creemos dentro de funciones
     * como start 
     * Y, se resolver�a colocando la variable como publica, �No?, pues no porque lo intent�
     * y Unity me hizo berrinche, no s� si sea por eso pero xd
    */

    // Start is called before the first frame update
    void Start()
    {
        GameObject luz_Nueva = new GameObject("luz_Nueva");
        // Crear un GameObject que ser� la luz, en este momento a�n no es luz porque no tiene el componente luz a�adido
        // Lo naranja es el nombre que le estamos dando en la interfaz al objeto reci�n creado

        luz_Con_Transform = luz_Nueva.transform;
        /* Como la variable luz con Transform si puede ser vista fuera de start, haremos que esta referencie a,
         * para as� poder manipularla indirectamente desde afuera y que unity lo permita, adem�s, agregamos de una vez el .transform
         * para no tener que colocarlo m�s tarde
        */

        Light luz = luz_Nueva.AddComponent<Light>();
        // A�adimos el componente luz al GameObject, cuando se crean luces autom�ticamente, siempre son "Point lights"

        luz.type = LightType.Spot;
        // Cambiamos la luz por default a otro tipo, en este caso, "Spot"

        Vector3 posicionLuz = new Vector3 (0,1,0);
        // Creamos una variable tipo Vector3 que nos ayudar� a definir la posici�n en la que aparecer� nuestra luz
        // La forma de declarar esto fue muy similar a la forma en la que se declara un nuevo GameObject

        luz.transform.position = posicionLuz;
        // Con esto hacemos que nuestra luz ahora si est� en la posici�n que le estamos diciendo con Vector3
    }

    // Update is called once per frame
    void Update()
    {
        luz_Con_Transform.LookAt(punto_De_Luz);
        /* LookAt es un m�todo que modificar� la orientaci�n del objeto al que se lo apliquemos (en este caso luz_Con_Transform)
         * para que apunte hacia otro objeto que debemos referenciar (punto_De_Luz)
         * 
        */
    }

    /*
     * TUTORIALES
     * Crear luces desde c�digo:
     * https://www.youtube.com/watch?v=mrLjPNIn4Xg
     */
}
