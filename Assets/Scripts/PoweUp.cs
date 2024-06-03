using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUp : MonoBehaviour
{
    [SerializeField] private float speedMultiplier = 2f; // Multiplicador de velocidad
    [SerializeField] private float duration = 5f; // Duración del efecto en segundos

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            if (player != null)
            {
                StartCoroutine(player.IncreaseSpeed(speedMultiplier, duration));
                Destroy(gameObject); // Destruir el power-up después de recogerlo
            }
        }
    }
}
