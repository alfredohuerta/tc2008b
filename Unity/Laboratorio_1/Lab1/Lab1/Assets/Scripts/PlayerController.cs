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

    //Variables multijugador
    public string inputId;

    //Variables cámara
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey; //Tecla que permite cambiar entre cámaras

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // inputId es un parámetro del jugador con el que se puede identificar quién lo controla, esta variable concatena los el eje con el id del jugador que está moviendose
        horizontalInput = Input.GetAxis("Horizontal" + inputId); 
        forwardInput = Input.GetAxis("Vertical" + inputId);

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

        //Cambio entre cámaras
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        }
}
