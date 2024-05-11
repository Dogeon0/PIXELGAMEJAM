using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public Canvas ui;
    public LevelLoader LevelLoader;
    public GameObject winner;
    public GameObject restButton;

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            //UI VICTORY
            //LoadScene 0
            ui.gameObject.SetActive(true);

            //Here i want the image to be visible
            winner.SetActive(true);
            restButton.SetActive(true);
            //Invoke("LoadLevel",2f);

        }
    }

    


    void RestartGame(){
        LevelLoader.LoadLevel(1);
    }

    void LoadLevel()
    {
        LevelLoader.LoadLevel(0);
    }
}
