using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fala : MonoBehaviour{
    //Quantas falas vão ter
    public Dialogo[] falas = new Dialogo[2];
    //vai saber se o dialogo foi concluido
    private bool TextoConcluido = false;

    DialogoController dialogoController;
    
    void Start()
    {
        dialogoController = FindObjectOfType<DialogoController>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().speed = 0;

            if (!TextoConcluido)
            {
                dialogoController.nextFala(falas[0]);

            }
            else {
                dialogoController.nextFala(falas[1]);
            }

            TextoConcluido = true; 
        }
    }
}
