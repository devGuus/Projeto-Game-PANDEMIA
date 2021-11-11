using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespostaButton : MonoBehaviour
{
    Respostas respostaData;

    public void nextFala() {

        FindObjectOfType<DialogoController>().nextFala(respostaData.nextFala);
    }

    public void Setup(Respostas resposta){

        respostaData = resposta;
    }
}
