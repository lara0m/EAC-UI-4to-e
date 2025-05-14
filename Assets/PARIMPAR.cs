using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PARIMPAR : MonoBehaviour
{
    public int num1;
    public TMP_InputField inputNum;
    public TextMeshProUGUI txtResultado;
    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }
    public void ParImpar()
    {
        num1 = int.Parse(inputNum.text);
        if(num1 <= 0)
        {
            txtResultado.text = "El número debe ser mayor a 0";
            return;

        } else if(num1 % 2 == 0)
        {
            txtResultado.text = "El número es par";
        } else
        {
            txtResultado.text = "El número es impar";
        }
        
    }

}
