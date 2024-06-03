using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera camaraPrincipal;
    private Vector3 mousePos;

    public GameObject bullet;
    public Transform bullletTransform;
    public bool puedeDisparar;
    private float timer;
    public float timeEntreDisparo;
    private float bulletSpeed = 10F;

    void Start()
    {

        camaraPrincipal = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); //Fuciona en el caso de tener multiples camaras
    }

    // Update is called once per frame
    void Update()
    {
       
        Disparo();
    }

    private void Rotacion()
    {
        mousePos = camaraPrincipal.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotacion = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotacion.y, rotacion.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90);
    }

    void Disparo()
    {
        if (!puedeDisparar)
        {
            timer += Time.deltaTime;
            if (timer > timeEntreDisparo)
            {
                puedeDisparar = true;
                timer = 0;
            }
        }
        else if(Input.GetMouseButton(0) && puedeDisparar)
        {

           
            Instantiate(bullet, bullletTransform.position , bullletTransform.rotation );
            Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
            rbBullet.velocity = (camaraPrincipal.ScreenToWorldPoint(Input.mousePosition) - transform.position ).normalized * bulletSpeed;
            puedeDisparar = false;
        }
    }
}
