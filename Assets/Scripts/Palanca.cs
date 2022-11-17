using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palanca : MonoBehaviour
{
    [SerializeField]
    private Text txt;
    [SerializeField]
    private Text numero;
    [SerializeField]
    private Text resultado;
    [SerializeField]
    private FunciónBooleana fb;

    // Start is called before the first frame update
    public void CompararPalanca(){
        Debug.Log(FunciónSingleton.GetNumero());
        Debug.Log(numero.text);
        if(FunciónSingleton.GetNumero() == int.Parse(numero.text)){
            resultado.text = "Palanca activada";
        }else
        {
            resultado.text = "Palanca incorrecta, intente de nuevo";
        }
        txt.text = "Busca la palanca número: " + FunciónSingleton.InstanciarNumero().ToString();
        StartCoroutine(Desactivar());
    }

    IEnumerator Desactivar(){
        yield return new WaitForSeconds(.3f);
        fb.SwitchActive();
    }
}
