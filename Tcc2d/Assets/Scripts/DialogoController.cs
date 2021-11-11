using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoController : MonoBehaviour
{
    public GameObject painelDeDialogo;

    public Text Dialogo;

    public GameObject respostas;

    private bool falaAtiva = false;

    Dialogo falas;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && falaAtiva){

            if (falas.respostas.Length > 0)
            
                MostrarResposta();
           
            else
            {
                falaAtiva = false;
                painelDeDialogo.SetActive(false);
                Dialogo.gameObject.SetActive(false);
                FindObjectOfType<PlayerController>().speed = 6;
            }
        }
    }

    void MostrarResposta() 
    {
        Dialogo.gameObject.SetActive(false);
        falaAtiva = false;

        for (int i = 0; i < falas.respostas.Length; i++) 
        {
            GameObject tempResposta = Instantiate(respostas, painelDeDialogo.transform) as GameObject;
            tempResposta.GetComponent<Text>().text = falas.respostas[i].resposta;
            tempResposta.GetComponent<RespostaButton>().Setup(falas.respostas[i]);
        }
    }
 
    public void nextFala(Dialogo fala){
        
        falas = fala;

        LimparRespot();

        falaAtiva = true;
        painelDeDialogo.SetActive(true);
        Dialogo.gameObject.SetActive(true);

        
    }

    void LimparRespot(){

        RespostaButton[] buttons = FindObjectsOfType<RespostaButton>();
        foreach (RespostaButton button in buttons) 
        {
            Destroy(button.gameObject);
        }
    }
}
