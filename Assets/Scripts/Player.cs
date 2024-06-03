using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    public int life = 3;
    private Camera camaraPrincipal;
    private Vector2 moveInput;
    private Vector3 mousePos;
    private Rigidbody2D rb;
    private float originalSpeed;
    void Start()
    {
        camaraPrincipal = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
       move();
       Rotacion();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
               
            life--;
            if(life == 0)
            {
                Destroy(gameObject);
                
            }
            Debug.Log("Colision con el enemigo");
        }
    }
    private void move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
    }
    private void Rotacion()
    {
        mousePos = camaraPrincipal.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotacion = mousePos - transform.position  ;

        float rotZ = Mathf.Atan2(rotacion.y, rotacion.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90);
    }

    public IEnumerator IncreaseSpeed(float multiplier, float duration)
    {
        speed *= multiplier;
        yield return new WaitForSeconds(duration);
        speed = originalSpeed;
    }
}
