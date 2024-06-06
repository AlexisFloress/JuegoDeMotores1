using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay : MonoBehaviour
{
    public GameObject[] vidas;  
    
    public void DesactivarVidas(int indice)
    {
        vidas[indice].SetActive(false);
    }
    public void ActivarVidas(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
