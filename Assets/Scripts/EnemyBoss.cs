using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : MonoBehaviour
{
    [SerializeField] private int vida = 5;
    [SerializeField] private GameObject player;
    public GameObject bullet;
    public Transform bullletTransform;
    public bool puedeDisparar;
    private float timer;
    public float timeEntreDisparo;
    private float bulletSpeed = 10F;




    void Update()
    {
        Rotacion();
        Disparo();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            vida--;
            if (vida == 0)
            {
                Destroy(gameObject);
            }


        }

        Debug.Log("Hay colosion enemigo");

    }


    private void Rotacion()
    {

        Vector3 rotacion = player.transform.position - transform.position;

        float rotZ = Mathf.Atan2(rotacion.y, rotacion.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);
    }
    void Disparo()
    {
        if (!puedeDisparar)
        {
            timer += Time.deltaTime;
            if (timer > timeEntreDisparo)
            {
                Instantiate(bullet, bullletTransform.position, bullletTransform.rotation);
                Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
                rbBullet.velocity = (player.transform.position - transform.position).normalized * bulletSpeed;
                puedeDisparar = false;

                timer = 0;
            }
        }





    }
}
