using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject Botonpausa;
    [SerializeField] private GameObject Menupausa;
   

    void Update()
    {
        
    }

    public void Puasa()
    {
        
      
            Time.timeScale = 0f;
            Botonpausa.SetActive(false);
            Menupausa.SetActive(true);
            
        
        //Debug.Log("Se esta llamando el metodo pausa");
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        Botonpausa.SetActive(true);
        Menupausa.SetActive(false);
        
    }
}
