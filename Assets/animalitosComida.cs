using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class animalitosComida : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputCodigo;
    public TMP_InputField inputCantDias;
    string codigo;
    int cantDias;
    int comidaP = 400;
    int comidaPG = 700;
    int comidaG = 300;
    int comidaAnimalIndicado;
    int cantComidaTotal;
    float precioPorCienGramos = 80;
    float precioTotal;


    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    public void CalcularComida()
    {
        if (inputCantDias.text == "")
        {
            txtResultado.text = "Debe ingresar una cantidad de dias";
            return;
        }
        if (inputCodigo.text == "")
        {
            txtResultado.text = "Debe ingresar un codigo";
        }
        codigo = inputCodigo.text;
        cantDias = int.Parse(inputCantDias.text);

        if (cantDias < 3)
        {
            txtResultado.text = "La cantidad de dias no puede ser menor a 3";
            return;
        }
        if (codigo == "G")
        {
            comidaAnimalIndicado = comidaG;
            

        } else if (codigo == "PP")
        {
            comidaAnimalIndicado = comidaP;
            
        } else if (codigo == "PG")
        {
            comidaAnimalIndicado = comidaPG;
            

        } else
        {
            txtResultado.text = "Codigo no valido";
            return;
        }

        cantComidaTotal = comidaAnimalIndicado * cantDias;
        precioTotal = cantComidaTotal / 100 * precioPorCienGramos;

        txtResultado.text = "Para ese periodo se necesitan " + cantComidaTotal + " gramos de comida, que saldran $ " + precioTotal;
    }
}
