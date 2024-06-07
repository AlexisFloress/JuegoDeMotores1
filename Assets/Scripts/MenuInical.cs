using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInical : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Empieza el juego");
    }

    public void Entrando()
    {
        Debug.Log("Empieza el juego");
    }

    public void Creditos()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log("Mostrando los creditos");
    }

    public void Regresar()
    {
        SceneManager.LoadScene("MenuInicial");
        Debug.Log("Se ejecuta el metodo regresar");
    }

    public void QuitGame()
    {
        
        Application.Quit();

        
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void JugarDeath()
    {
        SceneManager.LoadScene("GamePlay");
    }



}
