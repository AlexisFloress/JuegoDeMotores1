using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private Vector3 mousePos;
    private GameObject player;
    private Rigidbody2D rb;
    public float force;





    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        mousePos = player.transform.position;
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = mousePos - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);



    }
    private void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject,3f);
        }
    }
}
