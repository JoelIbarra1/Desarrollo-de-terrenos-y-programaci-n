using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripcamera : MonoBehaviour
{
    public Transform car; // Referencia al objeto del carro
    public Vector3 offset = new Vector3(0, 5, -10); // Posici�n de la c�mara con respecto al carro
    public float smoothSpeed = 0.125f; // Velocidad de suavizado


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Posici�n objetivo de la c�mara
        Vector3 desiredPosition = car.position + offset;
        // Movimiento suavizado entre la posici�n actual y la deseada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Hacer que la c�mara mire hacia el carro
        transform.LookAt(car);
    }
}
