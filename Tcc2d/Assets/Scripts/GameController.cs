using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public string Nivel;

    //public AudioClip SFX;
    //public MusicaController AudioController;
    public void RestartButton() 
    {
        SceneManager.LoadScene("Jogo");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Carro")
        {
            Destroy(GameObject.FindWithTag("Carro"));
        }

        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(Nivel);
        }
    } 
}
