using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variable que hace que liga la cámara conel objeto que designemos como nuestro jugador
    public GameObject player;

    // Variable que toma los valores del offset con la posiciónde la cámara
    private Vector3 offset = new Vector3(0, 100,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()

    // LateUpdate se manda a llamar después del Update
    void LateUpdate()
    {
        // transform.position = player.transform.position;

        // transform.position = player.transform.position + new Vector3(0,6,-7);

        // Modifica la posición de la cámara con en base al movimiento del jugador.
        transform.position = player.transform.position + offset;
    }
}
