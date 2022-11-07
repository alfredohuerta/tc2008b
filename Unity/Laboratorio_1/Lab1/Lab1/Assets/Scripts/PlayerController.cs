using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variable global que controla el manejo de la velocidad
    public float speed = 20.0f;

    // Variable global que controla la velocidad del giro del vehículo
    public float turnSpeed = 45.0f;

    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Mover el vehículo hacia adelante
        // transform.Translate(0,0,1);

        // Permite controlar la magnitud del vector 
        // transform.Translate(Vector3.forward * Time.deltaTime * 10);

        // Modificar el movimiento hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Modificar el giro
        transform.Translate(Vector3.right * Time.deltaTime* turnSpeed * horizontalInput);

        // Agrega rotación al vehículo cuando gira
        // transform.Rotate(Vector3.up,horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
