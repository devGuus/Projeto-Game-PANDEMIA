using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeController : MonoBehaviour
{

    public float volumeMusica, volumeFX;

    public Slider sliderMusica, sliderFX;
    // Start is called before the first frame update
    void Start()
    {
        sliderMusica.value = PlayerPrefs.GetFloat("Musica");
        sliderFX.value = PlayerPrefs.GetFloat("FX");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeMusica(float volume)
    {
        volumeMusica = volume;
        AudioListener.volume = volumeMusica;

        
        GameObject[] Musica = GameObject.FindGameObjectsWithTag("Musica");
        for (int i = 0; i < Musica.Length; i++)
        {
            Musica[i].GetComponent<AudioSource>().volume = volumeMusica;
        }

        PlayerPrefs.SetFloat("Musica", volumeMusica);
    }
    public void VolumeFX(float volume)
    {
        volumeFX = volume;
        GameObject[] Fxs = GameObject.FindGameObjectsWithTag("FX");
        for (int i = 0; i < Fxs.Length; i++)
        {
            Fxs[i].GetComponent<AudioSource>().volume = volumeFX;
        }
        PlayerPrefs.SetFloat("FX", volumeFX);

    }

}
