using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmaraFollow : MonoBehaviour
{
    [SerializeField] private float camaraVelocidad = 2f;
    [SerializeField] private Transform target;
    [SerializeField] private float size= 2;
    private Camera camara;

    private void Start()
    {
        camara = GetComponent<Camera>();
        camara.orthographicSize = size;
    }

    private void LateUpdate()
    {
       Vector3 newPos = new Vector3(target.position.x, target.position.y, -10);
       transform.position = Vector3.Slerp(transform.position,newPos,camaraVelocidad * Time.deltaTime);
    }

}
