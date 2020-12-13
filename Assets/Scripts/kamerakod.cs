using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakod : MonoBehaviour
{
    public GameObject top;
    
    Vector3 aradakiMesafe;
    void Start()
    {
        aradakiMesafe = transform.position - top.transform.position;

    }

    
    void LateUpdate()
    {   
        transform.position = top.transform.position + aradakiMesafe;
        

    }
    
}
