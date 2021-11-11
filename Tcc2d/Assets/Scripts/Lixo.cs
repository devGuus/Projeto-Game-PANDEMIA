using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lixo : MonoBehaviour
{
    public Text PontosLixo;

    public GameObject PainelAparecer;

    public string PainelWin;

    private int Pontos;
    void Start(){
        Pontos = 0;
        
        
    }
        
    // Update is called once per frame
    void Update()
    {
        PontosLixo.text = Pontos.ToString();
    }
    private void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("Garrafa") == true) {
            Pontos = Pontos + 1;
            Destroy(col.gameObject);
            
        }
        if (Pontos >= 50)
        {
            PainelAparecer.SetActive(true);
        }

        
    }
}
