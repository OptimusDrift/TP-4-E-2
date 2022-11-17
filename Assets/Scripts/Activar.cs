using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour
{
    
    public void ActivarCanvas(){
        gameObject.SetActive(true);
    }
    public void DesactivarCanvas(){
        gameObject.SetActive(false);
    }
}
