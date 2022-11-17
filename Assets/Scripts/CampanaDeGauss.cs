using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampanaDeGauss : MonoBehaviour
{
    [SerializeField]
    private Text txt;
    [SerializeField]
    private InputField porcentaje;
    [SerializeField]
    private InputField MidPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Calcular(){
        try
        {
            txt.text = GetBellCurvePoint(float.Parse(porcentaje.text),float.Parse(MidPoint.text)).ToString();
        }
        catch (System.Exception)
        {
            txt.text = "Error ingrese un numero.";
        }
    }

    private double GetBellCurvePoint(double Percentage, double Midpoint)
    {
        if (Percentage > Midpoint) {
            Percentage = 1 - Percentage;
            return 1 - ((Percentage - ((1 - Percentage) * Percentage)) * (1 / (1 - Midpoint)));
        } else {
            return (Percentage - ((1 - Percentage) * Percentage)) * (1 / Midpoint);
        }
    }

}
