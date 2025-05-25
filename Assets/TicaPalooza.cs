using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TicaPalooza : MonoBehaviour
{
    public TextMeshProUGUI txtResultadoPlata;
    public TextMeshProUGUI txtResultadoCapacidad;
    public TMP_InputField inputCampo;
    public TMP_InputField inputPlatea;

    int CapacidadCampo = 20400;
    int CapacidadPlatea = 16200;

    int entradasCampo;
    int entradasPlatea;
    // Start is called before the first frame update
    void Start()
    {
        txtResultadoPlata.text = "";
        txtResultadoCapacidad.text = "";
    }

    public void SumarEntradas() 
    {
        entradasCampo = int.Parse(inputCampo.text);
        entradasPlatea = int.Parse(inputPlatea.text);

        if(entradasCampo < 0 || entradasCampo > CapacidadCampo) {
            txtResultadoCapacidad.text = "La cantidad de entradas para campo no es valida";
            return;
        }

        if(entradasPlatea <0 || entradasPlatea > CapacidadPlatea) {
            txtResultadoCapacidad.text = "La cantidad de entradas para platea no es valida";
            return;
        }


        int CapacidadTotal = CapacidadCampo + CapacidadPlatea;
        int entradasVendidas = entradasCampo + entradasPlatea;
        int vacantes = CapacidadTotal - entradasVendidas;

        int cantidadRecaudadaCampo = entradasCampo * 1200;
        int cantidadRecaudadaPlatea = entradasPlatea * 2000;
        int cantidadRecaudadaTotal = cantidadRecaudadaCampo + cantidadRecaudadaPlatea;

        
        txtResultadoPlata.text = 
    "Lo recaudado para CAMPO es de $" + cantidadRecaudadaCampo + "\n" +
    "Lo recaudado para PLATEA es de $" + cantidadRecaudadaPlatea + "\n" +
    "La recaudación TOTAL es de $" + cantidadRecaudadaTotal;



        if(entradasVendidas == CapacidadTotal) {
            txtResultadoCapacidad.text = "Sold Out!";

        } else if(entradasVendidas > CapacidadTotal / 2) {
            txtResultadoCapacidad.text = "El festival fue un éxito!" + "\n" + "Sobraron " + vacantes;

        } else {
            txtResultadoCapacidad.text = "Debemos mejorar la convocatoria." + "\n" + "Sobraron " + vacantes;
        }
    }
}
