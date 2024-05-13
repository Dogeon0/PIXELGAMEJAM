using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
     public Transform target; // El objeto que seguirá la cámara
    public float distance = 5.0f; // Distancia inicial de la cámara al objetivo
    public float height = 2.0f; // Altura de la cámara sobre el objetivo
    public float smoothSpeed = 5.0f; // Velocidad de suavizado de la cámara

    void LateUpdate()
    {
        if (!target)
            return;

        Vector3 targetPosition = target.position + Vector3.up * height - target.forward * distance;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothSpeed);
        transform.LookAt(target.position);
    }
}
