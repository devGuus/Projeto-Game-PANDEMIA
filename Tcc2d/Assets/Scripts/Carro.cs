using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public float speed;
    public float moveTime;
    public AudioClip dead;


    private bool dirRight;
    private float tempo;


    // Update is called once per frame
    void Update()
    {
        if (dirRight)
        {
            // lado direito se for verdade
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            // lado esquerdo se for falso
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        tempo += Time.deltaTime;
        if (tempo >= moveTime)
        {

            dirRight = !dirRight;
            tempo = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("Player"));
            AudioSource.PlayClipAtPoint(dead, transform.position);
        }
    }
}
