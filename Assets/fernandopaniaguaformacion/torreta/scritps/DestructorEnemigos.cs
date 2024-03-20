using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorEnemigos : MonoBehaviour
{
    public string tag;

    public void OnCollisionEnter(Collision c){
        if (c.gameObject.CompareTag(tag)){
            Destroy(c.gameObject);
        }
    }
}
