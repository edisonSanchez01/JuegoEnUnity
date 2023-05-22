using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_pausa : MonoBehaviour
{

[SerializeField] private GameObject botonPausa;
[SerializeField] private GameObject menuPausa;  

public void pausa() 
{
    Time.timeScale = 0f;
    botonPausa.SetActive(false);
    menuPausa.SetActive(true);
}

public void reanudar() 
{
    Time.timeScale = 1f;
    botonPausa.SetActive(true);
    menuPausa.SetActive(false);
}

public void reiniciar() 
{
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
}

public void cerrar()
{
    Time.timeScale = 1f;
    SceneManager.LoadScene(0);
}

}
