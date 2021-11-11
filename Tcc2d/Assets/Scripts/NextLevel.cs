using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string Nivel;

    [SerializeField] private CanvasGroup loadingOverlay;
    [SerializeField]
    [Range(0.01f, 3f)]
    private float fadeTime = 0.15f;


        //Vai receber o tempo que vai esperar pra passar para o outro level
    IEnumerator NextLevelAfterWait()
    {
        yield return new WaitForSeconds(0.3f);

        SceneManager.LoadScene(Nivel);
    }
    //recebe a tag player e inicia os segundos WaitForSenconds
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(NextLevelAfterWait());

        other.GetComponent<PlayerController>().speed = 0;   
    }

    public static NextLevel Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadSceneAsync(string sceneName)
    {
        StartCoroutine(PerformLoadSceneAsync(sceneName));
    }

    private IEnumerator PerformLoadSceneAsync(string sceneName)
    {
        yield return StartCoroutine(FadeIn());

        var operation = SceneManager.LoadSceneAsync(sceneName);
        while (operation.isDone == false)
        {
            yield return null;
        }

        yield return StartCoroutine(FadeOut());
    }
       
    private IEnumerator FadeIn()
    {
        float start = 0;
        float end = 1;
        float speed = (end - start) / fadeTime;

        loadingOverlay.alpha = start;
        while (loadingOverlay.alpha < end)
        {
            loadingOverlay.alpha += speed * Time.deltaTime;
            yield return null;
        }

        loadingOverlay.alpha = end;

    }

    private IEnumerator FadeOut()
    {
        float start = 1;
        float end = 0;
        float speed = (end - start) / fadeTime;

        loadingOverlay.alpha = start;
        while (loadingOverlay.alpha > end)
        {
            loadingOverlay.alpha += speed * Time.deltaTime;
            yield return null;
        }

        loadingOverlay.alpha = end;
    }


}
