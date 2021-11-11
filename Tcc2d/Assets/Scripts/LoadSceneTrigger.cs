using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneTrigger : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public GameObject painel;

    public string Nivel;


    IEnumerator NextLevelAfterWait()
    {
        yield return new WaitForSeconds(0.2f);

        SceneManager.LoadScene(Nivel);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            StartCoroutine(NextLevelAfterWait());
            NextLevel.Instance.LoadSceneAsync(sceneName);
            painel.SetActive(true);

            
        }
       

    }
}
