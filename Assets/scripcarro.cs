using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripcarro : MonoBehaviour
{
    public float speed = 1100f; // Velocidad del carro
    public float turnSpeed = 700f; // Velocidad de giro
    public float customGravity = -30f; // Gravedad personalizada
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtener el Rigidbody del carro
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.up * customGravity);
        // Movimiento hacia adelante y atrás
        float moveDirection = Input.GetAxis("Vertical"); // Teclas W/S o flechas arriba/abajo
        transform.Translate(Vector3.forward * moveDirection * speed * Time.deltaTime);

        // Girar el carro
        float turnDirection = Input.GetAxis("Horizontal"); // Teclas A/D o flechas izquierda/derecha
        transform.Rotate(Vector3.up * turnDirection * turnSpeed * Time.deltaTime);
    }
}
