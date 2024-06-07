using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Overlay overlay;
    private int vidas = 4;
    public GameObject player;
    [SerializeField] private Animator animator;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("hay mas de un GameManager en escena");
        }
    }

    public void PerderVidas()
    {
        vidas--;
        overlay.DesactivarVidas(vidas);
        if(vidas == 0)
        {

            Destroy(player, 0.5f);
            SceneManager.LoadScene("Muerte");
        }
    }

    public void SiguienteHabitacion()
    {
        StartCoroutine(CargarHabitacion());
    }

    IEnumerator CargarHabitacion()
    {
        Debug.Log("Incio de la corrutina");
        animator.SetBool("End", true);
        yield return new WaitForSeconds(1.5f);
        animator.SetBool("End", false);
        animator.SetBool("Start", true);
        //animator.SetBool("Start", false);
        Debug.Log("Fin de la corrutina");
        
    }
}
