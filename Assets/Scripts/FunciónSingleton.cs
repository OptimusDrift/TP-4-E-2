using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunciónSingleton : MonoBehaviour
{
    public static FunciónSingleton instance;
    private static int numero = 3;

    public static FunciónSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new FunciónSingleton();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    public static int InstanciarNumero(){
        numero = Random.Range(1, 10);
        return numero;
    }

    public static int GetNumero(){
        return numero;
    }    
}
