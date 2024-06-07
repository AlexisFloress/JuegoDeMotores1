using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Puertas : MonoBehaviour
{
    [SerializeField] private GameObject[] habitaciones;
    [SerializeField] private Animator animator;
    private int habitacionAnterior = 0;
    private int habitacionActual = 0;
    Transform posicionTraslado;
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        string etiqueta = collision.tag.ToString();
        switch (etiqueta)
        {
            case "Puerta 0":
                habitacionActual = 0;

                habitaciones[habitacionActual].SetActive(true);

                posicionTraslado = habitaciones[habitacionActual].transform.GetChild(0);
                transform.position = posicionTraslado.transform.position;
                habitaciones[habitacionAnterior].SetActive(false);

                habitacionAnterior = 0;
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 1":
                habitacionActual = 1;

                habitaciones[1].SetActive(true);

                posicionTraslado = habitaciones[habitacionActual].transform.GetChild(0);
                transform.position = posicionTraslado.transform.position;
                habitaciones[habitacionAnterior].SetActive(false);

                habitacionAnterior = 1;
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 2":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 3":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 4":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 5":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 6":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 7":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 8":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 9":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
            case "Puerta 10":
                Debug.Log("Estoy dentro de la etiqueta 1");
                break;
        }


        Debug.Log(etiqueta);
    }
}
