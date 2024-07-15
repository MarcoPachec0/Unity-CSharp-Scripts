using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dronemoviment : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 3.0f;
    public float verticalSpeed = 3.0f;

    void Update()
    {
       // Capturar entradas dos analógicos
        float forwardInput = Input.GetAxis("Vertical"); // Analógico esquerdo (frente/trás)
        float sidewaysInput = Input.GetAxis("Horizontal"); // Analógico esquerdo (esquerda/direita)
        float verticalInput = Input.GetAxis("RightVertical"); // Analógico direito (cima/baixo)
        float rotationInput = Input.GetAxis("RightHorizontal"); // Analógico direito (esquerda/direita)

        // Aplicar movimento para frente e para trás
        transform.Translate(Vector3.forward * forwardInput * speed * Time.deltaTime);

        // Aplicar movimento para esquerda e direita
        transform.Translate(Vector3.right * sidewaysInput * speed * Time.deltaTime);

        // Aplicar rotação
        transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);

        // Aplicar movimento vertical apenas se não estiver rotacionando
        if (Mathf.Abs(rotationInput) < 0.1f)  // Ajuste o valor conforme necessário para evitar movimento involuntário
        {
            transform.Translate(Vector3.up * verticalInput * verticalSpeed * Time.deltaTime);
        }
    }
}
