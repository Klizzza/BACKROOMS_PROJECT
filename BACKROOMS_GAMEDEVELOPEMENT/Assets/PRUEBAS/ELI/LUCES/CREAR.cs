using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREAR : MonoBehaviour
{
    // VARIABLES
    [SerializeField] private Transform punto_De_Luz;
    /* Creamos esta variable para que en la interfaz de Unity se nos muestre un
     * campo donde colocaremos un objeto (puede ser lo que sea porque no especificamos
     * qué tipo de variable es) el objeto debe estar en la posición a dónde queremos
     * que apunte la luz que vamos a crear
    */
    Transform luz_Con_Transform;
    /* Esta variable es necesaria porque al ser creada fuera de cualquier función,
     * es una variable global dentro de este script, lo que permitirá a otras funciones
     * interactuar con ella, a diferencia de las variables que creemos dentro de funciones
     * como start 
     * Y, se resolvería colocando la variable como publica, ¿No?, pues no porque lo intenté
     * y Unity me hizo berrinche, no sé si sea por eso pero xd
    */

    // Start is called before the first frame update
    void Start()
    {
        GameObject luz_Nueva = new GameObject("luz_Nueva");
        // Crear un GameObject que será la luz, en este momento aún no es luz porque no tiene el componente luz añadido
        // Lo naranja es el nombre que le estamos dando en la interfaz al objeto recién creado

        luz_Con_Transform = luz_Nueva.transform;
        /* Como la variable luz con Transform si puede ser vista fuera de start, haremos que esta referencie a,
         * para así poder manipularla indirectamente desde afuera y que unity lo permita, además, agregamos de una vez el .transform
         * para no tener que colocarlo más tarde
        */

        Light luz = luz_Nueva.AddComponent<Light>();
        // Añadimos el componente luz al GameObject, cuando se crean luces automáticamente, siempre son "Point lights"

        luz.type = LightType.Spot;
        // Cambiamos la luz por default a otro tipo, en este caso, "Spot"

        Vector3 posicionLuz = new Vector3 (0,1,0);
        // Creamos una variable tipo Vector3 que nos ayudará a definir la posición en la que aparecerá nuestra luz
        // La forma de declarar esto fue muy similar a la forma en la que se declara un nuevo GameObject

        luz.transform.position = posicionLuz;
        // Con esto hacemos que nuestra luz ahora si esté en la posición que le estamos diciendo con Vector3
    }

    // Update is called once per frame
    void Update()
    {
        luz_Con_Transform.LookAt(punto_De_Luz);
        /* LookAt es un método que modificará la orientación del objeto al que se lo apliquemos (en este caso luz_Con_Transform)
         * para que apunte hacia otro objeto que debemos referenciar (punto_De_Luz)
         * 
        */
    }

    /*
     * TUTORIALES
     * Crear luces desde código:
     * https://www.youtube.com/watch?v=mrLjPNIn4Xg
     */
}
