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
            Destroy(player, 1f);
        }
    }

    public void SiguienteHabitacion()
    {
        StartCoroutine(CargarHabitacion());
    }

    IEnumerator CargarHabitacion()
    {
        animator.SetTrigger("End");
        yield return new WaitForSeconds(1);
        Debug.Log("Cambio de habitacion");
        animator.SetTrigger("Start");
    }
}
