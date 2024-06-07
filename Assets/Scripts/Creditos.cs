using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
   
    void Start()
    {
        Invoke("CerrarCreditos", 20);
      
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuInicial");
        }
    }

    public void CerrarCreditos()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}
