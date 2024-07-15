using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
     public Transform target;  // Referência ao transform do drone
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Verifica se o target (drone) está definido
        if (target != null)
        {
            // Atualiza a posição da câmera para seguir o drone, mantendo a posição da câmera
            // na mesma posição relativa ao drone
            transform.position = target.position;
        }
    }
}
