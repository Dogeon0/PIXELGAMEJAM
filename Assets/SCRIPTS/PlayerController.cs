using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  public float speed = 10.0f; // Velocidad de movimiento del jugador
    public float rotationSpeed = 100.0f; // Velocidad de rotación del jugador

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log(horizontalInput);
        Debug.Log(verticalInput);
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}
