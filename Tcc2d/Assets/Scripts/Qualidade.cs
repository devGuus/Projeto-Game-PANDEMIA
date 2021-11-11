using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Qualidade : MonoBehaviour
{

    public void Baixa(){

        QualitySettings.SetQualityLevel(0);
    }

    public void Media(){

        QualitySettings.SetQualityLevel(1);
    }

    public void Alta(){

        QualitySettings.SetQualityLevel(2);
    }

    //resoluções

    public void Resolucao01(){

        Screen.SetResolution(1920, 1080, true);
    }

    public void Resolucao02() {

        Screen.SetResolution(1440, 900, true);
    }

    public void Resolucao03()
    {

        Screen.SetResolution(1280, 720, true);
    }
}
