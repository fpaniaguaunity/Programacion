using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaniSimplePlayerMover : MonoBehaviour
{
    public float h;//DEFINICIÓN
    public float v;//DEFINICIÓN
    public float velocidadRotacion;
    public float velocidadTraslacion;
    void Start()
    {
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");//ASIGNACIÓN DE VALOR
        v = Input.GetAxis("Vertical");
        transform.Rotate(0,h*Time.deltaTime*velocidadRotacion,0);
        transform.Translate(0,0,v*Time.deltaTime*velocidadTraslacion);
    }
}
