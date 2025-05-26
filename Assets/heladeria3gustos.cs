using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class heladeria3gustos : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputCodigo;
    public TMP_InputField inputCantidad;
    float gramos;
    string codigo;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    public void CalcularHelado() 
    {
        codigo = inputCodigo.text;
        gramos = int.Parse(inputCantidad.text);
        float precioTotal;
        float precioPorKilo = 500;
        float promocion;

        if(gramos < 250 || gramos > 3000){
            txtResultado.text = "Cantidad no válida";
            return;
        }

        if(codigo == "CHO") {
            promocion = 0;
            precioTotal = gramos * precioPorKilo/1000 * (1 - promocion/100);
            txtResultado.text = "Tu pedido cuesta: $" + precioTotal;

        } else if(codigo == "FRU") {
            promocion = 10;
            precioTotal = gramos * precioPorKilo/1000 * (1 - promocion/100);
            txtResultado.text = "Tu pedido cuesta: $" + precioTotal;


        } else if (codigo == "DDL") {
            promocion = 0;
            precioTotal = gramos * precioPorKilo/1000 * (1 - promocion/100);
            txtResultado.text = "Tu pedido cuesta: $" + precioTotal;

        } else {
            txtResultado.text = "Codigo de helado no valido";
            return;
        }

    }
}
