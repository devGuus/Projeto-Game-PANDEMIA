using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class Menu : MonoBehaviour
{
    public string faze;



    public void StartGame(){

        SceneManager.LoadScene(faze);
    }

    private IEnumerator Abrir(){

        yield return new WaitForSeconds(0.5f);

    }

    public void QuitGame(){

        //Editando usar esse
        UnityEditor.EditorApplication.isPlaying = false;    
        //quando o jogo estiver compilado usar 
        //Application.Quit();
    }
}
