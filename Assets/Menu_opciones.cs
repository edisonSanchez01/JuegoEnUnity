using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Menu_opciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    
    public void cambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }

    public void cambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
  
}
