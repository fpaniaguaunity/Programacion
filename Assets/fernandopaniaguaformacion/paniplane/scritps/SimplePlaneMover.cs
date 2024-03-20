using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlaneMover : MonoBehaviour
{
    public float speed;
    public float angularSpeed;
    public float h;
    public float v;
    void Start()
    {
        
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");//ASIGNACIÓN DE VALOR
        v = Input.GetAxis("Vertical");
        transform.Rotate(
            v*Time.deltaTime*angularSpeed,
            h*Time.deltaTime*angularSpeed,
            0);
        transform.Translate(
            0,
            0,
            speed*Time.deltaTime);   
    }
}
