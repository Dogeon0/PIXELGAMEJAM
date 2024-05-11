using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOLA2 : MonoBehaviour
{
    public GameObject playerPrefab; // Referencia al prefab del jugador
    public Transform spawnPoint;    // Punto de aparición del jugador

    void Start()
    {
        SpawnPlayer(); // Llamamos al método SpawnPlayer al iniciar la escena
    }

    void SpawnPlayer()
    {
        // Comprobamos si el prefab del jugador y el punto de aparición están asignados
        if (playerPrefab != null && spawnPoint != null)
        {
            // Instanciamos el jugador en el punto de aparición
            GameObject playerInstance = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);

            // Opcional: Puedes hacer más configuraciones al instanciar el jugador, como establecer su posición, etc.
        }
        else
        {
            Debug.LogError("Prefab del jugador o punto de aparición no asignados en el script PlayerSpawner.");
        }
    }
}